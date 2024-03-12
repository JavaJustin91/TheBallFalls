using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{

    public GameObject pausedTitle;
    public Button resumeButton;
    public Button quitButton;
    public GameObject blur;

    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

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
        pausedTitle.SetActive(true);
        resumeButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
        blur.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausedTitle.SetActive(false);
        resumeButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
        blur.SetActive(false);
    }
}
