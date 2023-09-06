using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private MoveController _controller;

    private Vector2 _movementDIrection = Vector2.zero;
    private float speed;
    public float Speed
    {
        get { return speed; }
        set { speed = value; } 
    }

    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _controller = GetComponent<MoveController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        Speed = GameManager.Instance.PlayerSpeed;
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
