using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text bestScoreText;
    [SerializeField]
    private GameObject gameOverPanel;
    [SerializeField]
    private Text finalScoreText;

    void Start()
    {
        scoreText.text = "Score: 0";
        bestScoreText.text = "Best score: 0"; // need to edit
        gameOverPanel.SetActive(false);
    }

    public void UpdateScore(int newScore)
    {
        scoreText.text = $"Score: {newScore}";

        // if new score is bigger than best score --> update best score
    }

    public void GameOver(int score, int bestScore)
    {
        gameOverPanel.SetActive(true);
        finalScoreText.text = $"Your Score: {score}\nYour Best Score: {bestScore}";
        scoreText.gameObject.SetActive(false);
        bestScoreText.gameObject.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameScene"); // Reload Game Scene
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MenuSecene"); // Load Menu Scene
    }
}
