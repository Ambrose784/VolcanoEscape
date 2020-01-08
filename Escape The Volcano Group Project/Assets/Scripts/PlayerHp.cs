using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHp : MonoBehaviour
{
    public int health = 10;
    public Text healthText;
    public Slider healthSlider;
    public int lives = 10;

    private void Start()
    {
        healthText.text = "Health" + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;
        //PlayerPrefs.SetInt("lives", lives);
        lives = PlayerPrefs.GetInt("lives");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("DeathBarrier"))
        {
            health--;
            healthText.text = "Health: " + health;
            healthSlider.value = health;
            if (health < 4)
            {
                if (health < 4)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    SceneManager.LoadScene("Lose");
                    Player
                }
              
            }

        }

        if (collision.gameObject.tag == ("TileDeath"))
        {
            Destroy(gameObject);
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
                    SceneManager.LoadScene("GamerOver");
                }
                

            }
        }
    }
}
