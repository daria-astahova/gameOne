// Attach this script to your obstacle GameObjects
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); // Find the GameManager in the scene
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Increase the score when a player collides with the obstacle
            gameManager.PlayerHitObstacle();
        }
    }
}
