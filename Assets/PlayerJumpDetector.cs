using UnityEngine;

public class PlayerJumpDetector : MonoBehaviour
{
    // Reference to the players
    public Transform player1;
    public Transform player2;

    // Scores for each player
    private int player1Score = 0;
    private int player2Score = 0;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the trigger collider collided with the other player
        if (other.transform == player1 || other.transform == player2)
        {
            // Check the position or height of the players to determine if one player jumped over the other
            if (other.transform.position.y > transform.position.y)
            {
                // Increment the score of the player who jumped over the other
                if (other.transform == player1)
                {
                    player1Score++;
                    Debug.Log("Player 1 scored! Player 1 Score: " + player1Score);
                }
                else if (other.transform == player2)
                {
                    player2Score++;
                    Debug.Log("Player 2 scored! Player 2 Score: " + player2Score);
                }
            }
        }
    }
}
