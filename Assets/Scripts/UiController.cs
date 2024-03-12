using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public PlayerController player;
    public Slider healthSlider;

    public GameObject gameOverOverlay;
    public GameObject pauseOverlay;

    void Start()
    {
        player.GetComponent<PlayerController>();
    }

    void Update()
    {
        healthSlider.value = player.health;

        if(player.health <= 0)
        {
            GameOver();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            player.TakeDamage();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        pauseOverlay.SetActive(true);
    }

    public void GameOver()
    {
        // May want to create a transition here
        // for when we setup a crashing animation
        Time.timeScale = 0;
        gameOverOverlay.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseOverlay.SetActive(false);
    }

    public void RetryLevel()
    {
        Time.timeScale = 1;
        GameManager.Instance.RetryLevel();
    }

    public void ReturnToMain()
    {
        Time.timeScale = 1;
        GameManager.Instance.MainMenu();
    }

    public void QuitGame()
    {
        GameManager.Instance.QuitGame();
    }
    
}
