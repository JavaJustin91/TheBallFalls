using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    void Start()
    {
        Button quitButton = GetComponent<Button>();
        quitButton.onClick.AddListener(GameManager.Instance.QuitGame);
    }
}
