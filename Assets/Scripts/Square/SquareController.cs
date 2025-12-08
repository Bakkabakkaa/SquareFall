using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SquareController : MonoBehaviour
{
    [SerializeField] private float _rotationPower;
    [SerializeField] private float _speed;
    
    private Rigidbody2D _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rotationPower *= GetRandomSign();
    }

    private void FixedUpdate()
    {
        _rigidbody.rotation += _rotationPower;
        _rigidbody.linearVelocity = (Vector2.down + Vector2.left) * _speed;
    }

    private int GetRandomSign()
    {
        var randomNumber = Random.Range(0, 2);
        return randomNumber == 1 ? 1 : -1;
    }
}
