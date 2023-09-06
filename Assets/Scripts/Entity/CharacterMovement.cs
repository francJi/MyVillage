using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private MoveController _controller;

    private Vector2 _movementDIrection = Vector2.zero;
    [SerializeField] float speed;

    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _controller = GetComponent<MoveController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDIrection);
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        _movementDIrection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= speed;
        _rigidbody.velocity = direction;
    }
}
