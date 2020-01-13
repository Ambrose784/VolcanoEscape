using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D enemyRigidBody2D;
    public int UnitsToMove = 5;
    public float EnemySpeed = 500;
    public bool _isFacingRight;
    private float _startPos;
    private float _endPos;
    public float moveSpeed;
    public float jumpCount;
    public float maxJumps;
    public bool _moveRight = true;


    // Use this for initialization
    public void Awake()
    {
        enemyRigidBody2D = GetComponent<Rigidbody2D>();
        _startPos = transform.position.x;
        _endPos = _startPos + UnitsToMove;
        _isFacingRight = transform.localScale.x > 0;
    }


    // Update is called once per frame
    public void Update()
    {
        {
            float moveX = Input.GetAxis("Horizontal");
            Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
            velocity.x = moveSpeed * moveX;
            GetComponent<Rigidbody2D>().velocity = velocity;
            //if (Input.GetButtonDown("Jump") && jumpCount < maxJumps) //&& grounded)
            {
                
            }
           
            {
                
            }
           
            {
                
            }
        }
        if (_moveRight)
        {
            enemyRigidBody2D.AddForce(Vector2.right * EnemySpeed);// * Time.deltaTime);
            if (!_isFacingRight)
                Flip();
        }

        if (enemyRigidBody2D.position.x >= _endPos)
            _moveRight = false;

        if (!_moveRight)
        {
            enemyRigidBody2D.AddForce(-Vector2.right * EnemySpeed);// * Time.deltaTime);
            if (_isFacingRight)
                Flip();
        }
        if (enemyRigidBody2D.position.x <= _startPos)
            _moveRight = true;


    }

    public void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        _isFacingRight = transform.localScale.x > 0;
    }
}
