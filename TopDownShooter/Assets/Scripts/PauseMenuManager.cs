using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    private void Awake()
    {
        pauseMenu.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.gameManager.PauseGame(pauseMenu);
        }
    }

    public void ReturnToMainMenu()
    {
        GameManager.gameManager.ReturnToMainMenu();
    }
}
