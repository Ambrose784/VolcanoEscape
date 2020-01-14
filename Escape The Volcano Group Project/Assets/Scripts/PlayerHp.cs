using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHp : MonoBehaviour
{
    public int health = 3;
    public Text healthText;
    public Slider healthSlider;
    public int lives = 10;
    

    private void Start()
    {
        healthText.text = "Health" + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;
        PlayerPrefs.SetInt("lives", lives);
        lives = PlayerPrefs.GetInt("Lives");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("DeathBarrier"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.gameObject.tag == ("TileDeath"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.gameObject.tag == ("Enemy"))
        {
            health--;
            healthText.text = "Health: " + health;
            healthSlider.value = health;
            if (health < 1) 
            {
                if(lives > 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    //SceneManager.LoadScene("Lose");
                    PlayerPrefs.SetInt("lives", lives - 1);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }
                

            }
        }
        if (collision.gameObject.tag == ("Health"))
        {
            health++;
            healthText.text = "Health: " + health;
            healthSlider.value = health;
        }
        if (collision.gameObject.tag == ("Damage"))
        {
            health--;
            healthText.text = "Health: " + health;
            healthSlider.value = health;
            if (health < 1)
            {
                if (lives > 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    PlayerPrefs.SetInt("Lives", lives - 1);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
    }
    
    
}
