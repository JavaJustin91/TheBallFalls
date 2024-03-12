using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

#if UNITY_EDITOR
using UnityEngine.UI;
#endif

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    // private bool isPlaying = false;

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

    public void QuitGame()
    {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    //      ++++++++++++++++++++ SAVE FUNCTIONALITY (will need changed) ++++++++++++++++++++
    // [System.Serializable]
    // class SaveData
    // {
    //     public int score;
    //     public string name;
    // }

    // public void SaveTopScore(int scoreToSave, string nameToSave)
    // {
    //     SaveData data = new SaveData();
    //     data.score = scoreToSave;
    //     data.name = nameToSave;

    //     string json = JsonUtility.ToJson(data);

    //     File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    // }

    // public void LoadTopScore()
    // {
    //     string path = Application.persistentDataPath + "/savefile.json";
    //     if (File.Exists(path))
    //     {
    //         string json = File.ReadAllText(path);
    //         SaveData data = JsonUtility.FromJson<SaveData>(json);

    //         highScore = data.score;
    //         highScorePlayer = data.name;
    //     }
    // }
}
