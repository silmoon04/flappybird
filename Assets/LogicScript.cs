using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;
    [ContextMenu("Score")]
    public void addScore()
    {
        playerScore += 1;
        scoreText.SetText(playerScore.ToString());
    }
}
