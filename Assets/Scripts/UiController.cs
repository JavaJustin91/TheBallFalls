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
            GameManager.Instance.GameOver(gameOverOverlay);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            player.TakeDamage();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Instance.PauseGame(pauseOverlay);
        }
    }
    
}
