using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float score = 0;
    private float scoreRate = 5; // The amount which is added to score every second
    private float scoreRateIncreasement = 0.25f; // The amount which is added to "Score Rate" as much as game speed increases
    private int bestScore;
    private UIManager UI_Manager;
    private Animator running_Animator;
    private AudioSource music_Player;
    public bool isGameOver = false;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        UI_Manager = GameObject.Find("UI_Manager").GetComponent<UIManager>();
        running_Animator = GameObject.Find("pepsiman").GetComponent<Animator>();
        music_Player = GameObject.Find("Music_Player").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (isGameOver)
            return;

        score += scoreRate * Time.deltaTime;
        scoreRate += scoreRateIncreasement * Time.deltaTime;

        if ((int)score > bestScore)
        {
            bestScore = (int)score;
            PlayerPrefs.SetInt("BestScore", bestScore);
        }

        UI_Manager.UpdateScore((int)score, bestScore);
    }

    public void GameOver()
    {
        isGameOver = true;
        running_Animator.speed = 0;
        music_Player.Stop();
        UI_Manager.ShowGameOver((int)score, bestScore);
    }
}
