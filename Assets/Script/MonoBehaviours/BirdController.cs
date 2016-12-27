using System.Collections;
using UnityEngine;

public class BirdController : MonoBehaviour {

    public float speed;
    public float flapPower;
    public float spinPower;
    public float idleSpin;

    private bool idling;
    private bool isDead;

    private Rigidbody2D rb;

    private void Start() {

        rb = GetComponent<Rigidbody2D>();
        idling = true;
        isDead = false;
    }

    private void Update() {
        
        if (idling) {
            Idle();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && !isDead) {
            Flap();
        }

    }

    public void StartMoving() {
        Debug.Log("Bird: Start Moving");
        rb.velocity = Vector2.right * speed;
        rb.gravityScale = 1f;
        idling = false;
        isDead = false;
    }

    public void Flap() {
        Debug.Log("Bird: Flap");
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.AddForce(Vector2.up * flapPower, ForceMode2D.Impulse);

        rb.AddTorque(spinPower,ForceMode2D.Impulse);

    }
    public void Die() {
        Debug.Log("Bird: Die!!");
        //rb.gravityScale = 0f;
        isDead = true;
    }

    public void SetIdling() {
        Debug.Log("Bird: Set Idle");
        rb.velocity = Vector2.zero;
        rb.gravityScale = 0f;
        idling = true;
        isDead = false;
    }

    private void Idle() {
        Debug.Log("Bird: Idling");
        //rb.velocity = new Vector2(0f, idleHeight * Mathf.Cos(Time.unscaledTime * idleSpeed));
        rb.angularVelocity = idleSpin;
    }

}
