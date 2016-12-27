using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour {

    public GameObject player;

    private GameController gameController;

    private void Start() {
        gameController = GameObject.FindObjectOfType<GameController>();
    }

    private void Update () {
		
        float xposition = player.transform.position.x;
        transform.position = new Vector3(xposition, transform.position.y, transform.position.z);

	}

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject == player) {
            gameController.StopPlaying();
        }

    }
}
