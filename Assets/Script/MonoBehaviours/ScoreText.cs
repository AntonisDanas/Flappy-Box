using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    private Text scoreText;

	private void Start () {
        scoreText = GetComponent<Text>();
	}
	
	public void UpdateScore(int score) {
        scoreText.text = "Score: " + score;
    }
}
