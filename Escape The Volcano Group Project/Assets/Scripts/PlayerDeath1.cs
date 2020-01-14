using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath1: MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "vboi" || collision.gameObject.tag == "spike" )//|| collision.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.tag == "portal")
        {
            SceneManager.LoadScene("Level 2");
        }
    
    }
}
