using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HudManager : MonoBehaviour
{
    public Entity player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;

    private void Update()
    {
        scoreText.text = "Score: " + GameManager.gameManager.currentScore;
        healthText.text = "Health: " + player.currentHealth;

        if(GameManager.gameManager.isPaused)
        {
            scoreText.gameObject.SetActive(false);
            healthText.gameObject.SetActive(false);
        }
        else
        {
            scoreText.gameObject.SetActive(true);
            healthText.gameObject.SetActive(true);
        }
    }
}
