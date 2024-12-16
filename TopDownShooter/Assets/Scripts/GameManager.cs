using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager { get; private set; }

    public int currentScore = 0;

    public bool isPaused = false;

    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }

        if (!isPaused)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = false;
        }
        currentScore = 0;
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

        if(isPaused)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = false;
        }

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
