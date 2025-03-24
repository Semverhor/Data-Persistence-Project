using UnityEngine;

public class DataManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static DataManager Instance;
    public string playerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}