using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    private Player _player;
    private Rigidbody _rb;

    public void StartEnemy(Player player)
    {
        _rb = GetComponent<Rigidbody>();
        _player = player;
    }

    private void Update()
    {
        if (_player.isAppleCollected)
        {
            var direction = _player.transform.position - transform.position;
            _rb.position += direction.normalized * speed * Time.deltaTime;
        }
    }
}
