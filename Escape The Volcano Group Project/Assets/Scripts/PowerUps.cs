using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public float SpeedGain = 10;
    public float HealthGain = 3;
    public float JumpSpeedlost = 10;
    public float ShootDelay = 1.0f;
    public int Movespeed;
    float timer = 0;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Speed"))
        {
            if (Movespeed < 1.6)
            {
                SpeedGain++;
            }
            Time.deltaTime
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
