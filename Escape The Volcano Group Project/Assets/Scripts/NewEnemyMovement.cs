using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyMovement : MonoBehaviour
{
    Rigidbody2D enemyRigidBody2D;
    public int UnitsToMove = 5;
    public float EnemySpeed = 5;
    public bool _isFacingRight;
    private float _startPos;
    private float _endPos;
    public float moveSpeed;
    public bool _moveRight = true;
    public bool grounded;
    public float velocity, x, y;
   
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
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
            enemyRigidBody2D = GetComponent<Rigidbody2D>();
            _startPos = transform.position.x;
            _endPos = _startPos + UnitsToMove;
            _isFacingRight = transform.localScale.x > 0;
            //if (Input.GetButtonDown("Jump") && jumpCount < maxJumps) //&& grounded)
            anim.SetBool("grounded", grounded);
           // anim.SetFloat("x", velocity.x);
        //anim.SetFloat("y", velocity.y);
           
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 0 && !collision.isTrigger)
        {
            grounded = true;
            
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 0 && !collision.isTrigger)
        {
            grounded = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 0 && !collision.isTrigger)
        {
            grounded = false;
            //jumpCount = 0;
        }
    }
}
