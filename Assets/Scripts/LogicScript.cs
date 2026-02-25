using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Birdscript bird;
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource sound;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if(bird.birdIsaAlive == true)
        {
            playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
            sound.Play();
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
