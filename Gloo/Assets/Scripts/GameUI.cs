
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {
    public static int playerScore = 0;
    public Text scoreText;
    public void Update()
    {
            scoreText.text = "SCORE: " + playerScore;
    }

}
