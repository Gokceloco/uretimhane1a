using System.Xml;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
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
        transform.position += direction.normalized * speed * Time.deltaTime;
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
        }
    }
}
