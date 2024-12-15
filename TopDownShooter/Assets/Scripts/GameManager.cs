using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private Scene currentScene;
    public GameObject PauseMenu;

    private bool isPaused = false;

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        Debug.Log("Current Scene: " + currentScene.name);
    }

    private void Update()
    {
        if(currentScene.name == "GameScene")
            if (Input.GetKeyDown(KeyCode.Escape))   
            {
                PauseGame();
            }
        
    }

    private void PauseGame()
    {
        isPaused = !isPaused;
        PauseMenu.SetActive(isPaused);
        Time.timeScale = isPaused ? 0 : 1;
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
