﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static int playerScore = 0;
    public static int playerHealth = 100;
    public Text scoreText;
    public Slider healthBar;

    public void Update()
    {
        
        scoreText.text = "SCORE: " + playerScore;
        healthBar.value = playerHealth;
    }

}
