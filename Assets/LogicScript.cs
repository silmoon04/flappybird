using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;
    
    
    [ContextMenu("Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.SetText(playerScore.ToString());
    }

    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if (gameOverScreen != null)
        {
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
        }
        else
        {
            Debug.LogError("GameOverScreen is not assigned or is null.");
        }
    }
}
