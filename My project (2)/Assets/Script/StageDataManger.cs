using System.Collections.Generic;
using System.IO;
using UnityEditor.SceneManagement;
using UnityEngine;

[System.Serializable]
public class StageResult
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public string playerName;
   public int stage;
   public int score;
}
[System.Serializable]

public class StageResultList
{
    public List<StageResult> results = new List<StageResult>();
}

public static class StageResultSaver
{
    private const string FILE = "stage_results.json";

    private const string PLAYER_NAME = "PlayerName";

    private static string filePath = Path.Combine(Application.persistentDataPath, FILE);

    public static void SaveStage(int stage, int score)
    {
        StageResultList list = LoadInternal();
        string playerName = PlayerPrefs.GetString(PLAYER_NAME, "");
        StageResult entry = new StageResult
        {
            playerName = playerName,
            stage = stage,
            score = score
        };
        list.results.Add(entry);
    }

public static StageResultList LoadRank()
    {
        return LoadInternal();
    }
    private static StageResultList LoadInternal()
    {
        if (!File.Exists(filePath))
        return new StageResultList();
        string json = File.ReadAllText(filePath);
        StageResultList list = JsonUtility.FromJson<StageResultList>(json);
        if (list == null)
        return new StageResultList();
        else
        return list;
    }
}