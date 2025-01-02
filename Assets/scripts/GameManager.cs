using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int playerScore;
    private int computerScore;

    public void PlayerScores()
    {
        playerScore++;
        this.playerScoreText.text = playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        computerScore++;
        this.computerScoreText.text = computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        ball.ResetPosition();
        ball.AddStartingForce();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
    }
}
