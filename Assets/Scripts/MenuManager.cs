using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void Update()
    {
        // Press ESC key to quit the game
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Load Game Scene
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
