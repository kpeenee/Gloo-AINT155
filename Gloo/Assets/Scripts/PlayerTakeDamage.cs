﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTakeDamage : MonoBehaviour {
    public float startTimeBtwDamage = 1.0f;
    public float timeBtwDamage = 1.0f;


    private void Update()
    {
        timeBtwDamage -= Time.deltaTime;
    }



    private void OnCollisionStay2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {
            if (timeBtwDamage <= 0)
            {
                GameManager.playerHealth -= 10;
                timeBtwDamage = startTimeBtwDamage;
            }
            
  
        }

        if(GameManager.playerHealth <= 0)
        {
            Cursor.visible = true;
            SceneManager.LoadScene("GameOver");
            GameManager.playerHealth = 100;
            GameManager.playerScore = 0;
        }

        
    }
    
    
}
