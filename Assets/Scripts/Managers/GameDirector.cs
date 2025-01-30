using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public Player player;

    public EnemyManager enemyManager;

    private void Start()
    {
        RestartLevel();   
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        enemyManager.RestartEnemyManager();
    }
}
