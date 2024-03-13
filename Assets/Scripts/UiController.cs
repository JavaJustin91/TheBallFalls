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

    public void GameOver()
    {
        // May want to create a transition/wait here
        // for when we setup a crashing animation
        gameOverOverlay.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseOverlay.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseOverlay.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ReloadLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentLevel, LoadSceneMode.Single);
    }

}
