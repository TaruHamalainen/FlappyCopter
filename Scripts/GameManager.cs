using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameOverScreen;
    public Text scoreText;
    public Player player;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    private void Start()
    {
        scoreText.text = " " + player.score;
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverScreen.gameObject.SetActive(true);

    }
    public void UpdateScore()
    {
        player.score++;
        scoreText.text = " " + player.score;
    }
    public void RestartGame(int index)
    {
        SceneManager.LoadScene(index);
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
