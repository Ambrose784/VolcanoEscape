﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath: MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "vboi" || collision.gameObject.tag == "spike" )//|| collision.gameObject.tag == "Enemy")
         {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         }
         if (collision.gameObject.tag == "portal")
         {
         SceneManager.LoadScene("Level 2");
         }
         if (collision.gameObject.tag == "portal 2")
        {
            SceneManager.LoadScene("Level 3");
        }
         if (collision.gameObject.tag == "portal 3")
        {
            SceneManager.LoadScene("Winner!");
        }
    }
}
