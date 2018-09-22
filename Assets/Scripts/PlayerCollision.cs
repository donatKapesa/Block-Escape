using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            // game over or reduce life
            // communicate with PlayerMovement and turn on  gravity
            // I want player movement to stop completely
            // maybe use constraints
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}