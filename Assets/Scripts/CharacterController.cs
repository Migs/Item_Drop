using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 500f;

    private Rigidbody2D _rb;
    private Vector2 _movement;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb.AddForce(_movement * _speed * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        _movement = value.Get<Vector2>();
        Debug.Log("Test");
    }
}
