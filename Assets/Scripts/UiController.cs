using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public PlayerController player;
    public Slider healthSlider;

    public GameObject gameOverOverlay;
    public GameObject pauseOverlay;
    public GameObject goalOverlay;

    public GameObject nextLevelButton;

    void Update()
    {
        healthSlider.value = player.health;

        if(player.hitKillBox)
        {
            ReloadLevel();
        } 
        else if(player.health <= 0)
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

        if(player.hitGoal)
        {
            goalOverlay.SetActive(true);
            int currentLevel = SceneManager.GetActiveScene().buildIndex;
            if (currentLevel == SceneManager.sceneCountInBuildSettings - 1)
            {
                nextLevelButton.SetActive(false);
            }
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

    public void NextLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentLevel + 1, LoadSceneMode.Single);
    }

}
