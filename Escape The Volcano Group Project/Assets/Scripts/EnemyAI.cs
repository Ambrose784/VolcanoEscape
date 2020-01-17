using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    #region VARIABLES
    [Header("Movement Settings")]
    public Vector2 moveDir;
    public int moveSpeed;
    public int paceDuration;
    float moveTimer = 0;
    GameObject player;
    Vector2 chaseDirection;
    bool left;
    #endregion
    //UNITY FUNCTIONS
    #region UPDATE FUNCTION
    void Update()
    {
        //shootTimer += Time.deltaTime;
        if (GetComponent<Rigidbody2D>().bodyType != RigidbodyType2D.Static)
        {
            moveTimer += Time.deltaTime;
            GetComponent<Rigidbody2D>().velocity = moveDir * moveSpeed;
        }
        if (moveTimer > paceDuration)
            PaceSwitch();
    }
    #endregion
    //ENEMY AI FUNCTIONS
    #region PACE SWITCH FUNCTION
    void PaceSwitch()
    {
        left = !left;
        moveDir *= -1;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        moveTimer = 0;
    }
    #endregion
}

