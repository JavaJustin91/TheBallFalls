using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using System.IO; // For saving data

#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // Data to save
    // private int highestLevel;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    //  ++++++++++++++++++++ SAVE FUNCTIONALITY (will need connected) ++++++++++++++++++++
    // [System.Serializable]
    // class SaveData
    // {
    //     public int highestLevel;
    // }

    // public void SaveHighestLevel(int levelToSave)
    // {
    //     SaveData data = new SaveData();
    //     data.highestLevel = levelToSave;

    //     string json = JsonUtility.ToJson(data);

    //     File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    // }

    // public void LoadHighestLevel()
    // {
    //     string path = Application.persistentDataPath + "/savefile.json";
    //     if (File.Exists(path))
    //     {
    //         string json = File.ReadAllText(path);
    //         SaveData data = JsonUtility.FromJson<SaveData>(json);

    //         highestLevel = data.highestLevel;
    //     }
    // }
}
