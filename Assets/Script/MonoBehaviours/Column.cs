using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour {

    private GameController gameController;

    private void Start() {
        gameController = GameObject.FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        gameController.StopPlaying();
    }

}
