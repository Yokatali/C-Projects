using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed;

    public GameDirector gameDirector;

    private float _currentSpeed;

    public bool isAppleCollected;
    
    private Rigidbody _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void RestartPlayer()
    {
        gameObject.SetActive(true);
        _rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(6.5f, 0.5f, -10f);
        isAppleCollected = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collactable"))
        {
            other.gameObject.SetActive(false);
            gameDirector.levelManager.AppleCollected();
            isAppleCollected = true;
        }
        if (other.CompareTag("Door") && isAppleCollected)
        {
            gameDirector.levelComplated();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        var direction = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _currentSpeed = speed * 2f;
        }
        else
        {
            _currentSpeed = speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        _rb.linearVelocity = direction.normalized * _currentSpeed;
        /*transform.position += direction * speed * Time.deltaTime;*/
    }
}



/*transform.position = transform.position + Vector3.forward * speed * Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
            transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + Vector3.down * speed * Time.deltaTime;
        }*/
