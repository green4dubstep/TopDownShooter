using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager { get; private set; }
    private Scene currentScene;

    private int currentScore = 0;

    private bool isPaused = false;

    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }

        currentScene = SceneManager.GetActiveScene();
        Debug.Log("Current Scene: " + currentScene.name);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void PauseGame(GameObject pauseMenu)
    {
        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);
        Time.timeScale = isPaused ? 0 : 1;
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void AddScore(int score)
    {
        currentScore += score;
        Debug.Log("Current Score: " + currentScore);
    }
}
