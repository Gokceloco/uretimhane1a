using System.Xml;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameDirector gameDirector;

    public bool isAppleCollected;
    public float speed;

    private Rigidbody _rb;

    public Transform cameraHolder;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        _rb.position += direction.normalized * speed * Time.deltaTime;

        var pos = transform.position;
        pos.x = 0;
        cameraHolder.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {       
        if (other.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }
        if (other.CompareTag("Apple"))
        {
            var apple = other.gameObject;
            apple.SetActive(false);
            isAppleCollected = true;
        }
    }
}
