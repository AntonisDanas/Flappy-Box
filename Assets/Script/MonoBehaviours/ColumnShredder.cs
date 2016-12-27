using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnShredder : MonoBehaviour {

    public GameObject player;
    public float offset;

    private void Update() {
        float xposition = player.transform.position.x + offset;
        transform.position = new Vector3(xposition,0f,0f);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);
    }

}
