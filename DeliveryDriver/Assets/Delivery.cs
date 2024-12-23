using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision detected");
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Trigger triggered");
    }
}
