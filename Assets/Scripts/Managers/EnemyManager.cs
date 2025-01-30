using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameDirector gameDirector;

    public Enemy enemyPrefab;

    public int enemyCount;

    public List<Enemy> enemies;

    public void RestartEnemyManager()
    {
        DestroyEnemies();
        GenerateEnemies();
    }

    private void GenerateEnemies()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            var newEnemy = Instantiate(enemyPrefab);
            newEnemy.transform.position = new Vector3(Random.Range(-2.8f, 2.8f), 0, 1 + i);
            newEnemy.StartEnemy(gameDirector.player);
            enemies.Add(newEnemy);
        }          
    }

    private void DestroyEnemies()
    {
        foreach (var e in enemies) 
        {
            Destroy(e.gameObject);
        }
        enemies.Clear();
    }
}
