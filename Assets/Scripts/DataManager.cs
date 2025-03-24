using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public int highScore;
    public static DataManager Instance;
    public string playerName;
    public string highScorePlayerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadData();
    }


    [System.Serializable]
    class SaveData
    {
        public int highScore;
        public string highScorePlayerName;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.highScore = highScore;
        data.highScorePlayerName = highScorePlayerName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        Debug.Log("Save Complete");
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            Debug.Log("Save file path: " + path);
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.highScore;
            highScorePlayerName = data.highScorePlayerName;
            Debug.Log("Data loaded: High Score = " + highScore + ", Player Name = " + highScorePlayerName);
        }
        else
        {
            Debug.Log("No save file found, using default values.");
        }
    }

}