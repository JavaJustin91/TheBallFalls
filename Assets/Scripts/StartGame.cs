using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    void Start()
    {
        Button startButton = GetComponent<Button>();
        startButton.onClick.AddListener(GameManager.Instance.StartGame);
        Time.timeScale = 1;
    }

}
