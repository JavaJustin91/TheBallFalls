using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{

    public GameObject pauseOverlay;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        pauseOverlay.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseOverlay.SetActive(false);
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
