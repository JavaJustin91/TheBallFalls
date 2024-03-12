using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    Button startButton;

    void Start()
    {
        startButton = gameObject.GetComponent<Button>();
        startButton.onClick.AddListener(LoadFirstLevel);
    }

    // Update is called once per frame
    void LoadFirstLevel()
    {
        GameManager.Instance.StartGame();
    }
}
