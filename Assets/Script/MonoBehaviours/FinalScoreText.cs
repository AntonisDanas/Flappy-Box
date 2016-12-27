using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreText : MonoBehaviour {

    private Text scoreText;

    private void Start() {
        scoreText = GetComponent<Text>();
    }

    public void SetFinalScore(int score) {
        scoreText.text = "Your Score: " + score;
    }
}
