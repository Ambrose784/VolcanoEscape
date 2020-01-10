using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Player;
    public float BulletSpeed = 1.0f;
    public float ShootDelay = 1.0f;
    public float BulletLifeTime = 1.0f;
    float timer = 0;
    private object PlayerPosition;
    
    

    // Start is called before the first frame update
    void Start()
    {

        //Player.position.x;
        //Player.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > ShootDelay)

        {
            timer = 0;
            GameObject EnemyBullet = Instantiate(Prefab, transform.position, Quaternion.identity);
            Vector3 PLayerPosition = Player.position;
            
            
            Vector2 shootDir = new Vector2(PLayerPosition.x - transform.position.x,
                PLayerPosition.y - transform.position.y);
            shootDir.Normalize();
            EnemyBullet.GetComponent<Rigidbody2D>().velocity = shootDir * BulletSpeed;
            Destroy(EnemyBullet, BulletLifeTime);
        }
    }
}