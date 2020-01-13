using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public float Movespeed = 10;
    public float HealthGain = 3;
    public float JumpSpeedlost = 10;
    public float ShootDelay = 1.0f;
    public float Damage = 3;
    //public int Movespeed;
   // float timer = 0;
    public int health;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Speed"))
        {
            if (Movespeed < 10)
            {
                Movespeed++;
            }
        }

        if (collision.gameObject.tag == ("Health"))
        {
            if (health < 3)
            {
                health++;
            }
            
        }

        if (collision.gameObject.tag == ("Damage"))
            {
                health--;
            }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
