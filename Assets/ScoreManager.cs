using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text player1ScoreText;
    public Text player2ScoreText;
    public Text winText;

    private int player1Score = 0;
    private int player2Score = 0;

    private const int winScore = 4; // Score needed to win

    void Start()
    {
        UpdateScoreUI();
    }

    public void Player1Scored()
    {
        player1Score++;
        CheckWin();
        UpdateScoreUI();
    }

    public void Player2Scored()
    {
        player2Score++;
        CheckWin();
        UpdateScoreUI();
    }

    void CheckWin()
    {
        if (player1Score >= winScore)
        {
            winText.text = "Player 1 Won!";
        }
        else if (player2Score >= winScore)
        {
            winText.text = "Player 2 Won!";
        }
    }

    void UpdateScoreUI()
    {
        player1ScoreText.text = "Player One: " + player1Score;
        player2ScoreText.text = "Player Two: " + player2Score;
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Player1Box") && other.transform.parent.CompareTag("Player1"))
    //     {
    //         Player1Scored();
    //     }
    //     else if (other.CompareTag("Player2Box") && other.transform.parent.CompareTag("Player2"))
    //     {
    //         Player2Scored();
    //     }
    // }
}
