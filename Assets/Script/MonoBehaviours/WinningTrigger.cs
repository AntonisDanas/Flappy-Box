using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningTrigger : MonoBehaviour {

    private GameObject player;
    private GameController gameController;

    private void Start() {
        gameController = GameObject.FindObjectOfType<GameController>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject == player) {
            gameController.ScorePoint();
        }
    }

}
