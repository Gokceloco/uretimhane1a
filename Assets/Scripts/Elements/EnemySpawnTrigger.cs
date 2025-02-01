using UnityEngine;

public class EnemySpawnTrigger : MonoBehaviour
{
    public EnemyManager enemyManager;

    public BoxCollider boxCollider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemyManager.GenerateEnemiesForTrigger(transform.position);
        }
        boxCollider.enabled = false;
    }
}
