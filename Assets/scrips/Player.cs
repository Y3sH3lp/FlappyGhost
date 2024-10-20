using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;

    AudioManager audioManager;

    private Rigidbody2D _rb;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioManager.PlaySFX(audioManager.wings);
            _rb.velocity = Vector2.up * _velocity;
        }
    }
   
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioManager.PlaySFX(audioManager.die);
        GameManager.instance.GameOver();
    }
}
