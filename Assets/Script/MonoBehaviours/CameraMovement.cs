using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    
    public GameObject target;
    public float cameraOffset;

    private bool isFollowing;

    private void Start() {
        isFollowing = false;
        Follow(); // just to get into position
    }

    private void Update() {
        if (isFollowing) {
            Follow();
        }
    }

    public void StartFollowing() {
        Debug.Log("Camera: Start Following");
        isFollowing = true;
    }

    public void StopFollowing() {
        Debug.Log("Camera: Stop Following");
        isFollowing = false;
    }

    private void Follow() {
        Debug.Log("Camera: Follow");
        float newXPosition = target.transform.position.x + cameraOffset;
        transform.position = new Vector3(newXPosition, 0f, -10f);
    }
}
