using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player player;
    public float speed;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (player.isAppleCollected)
        {
            var direction = player.transform.position - transform.position;
            _rb.position += direction.normalized * speed * Time.deltaTime;
        }
    }
}
