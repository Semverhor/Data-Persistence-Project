using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    public InputField inputField;

    // Start is called before the first frame update
    private void Awake()
    {
        DataManager.Instance.LoadData();
    }

    void Start()
    {

    }

    public void NameFromUnity()
    {
        string name = inputField.text; // Always fetch from InputField
        Debug.Log("Name fetched from InputField: " + name);

        if (DataManager.Instance != null)
        {
            DataManager.Instance.playerName = name;
            Debug.Log("Player name saved in DataManager: " + DataManager.Instance.playerName);
        }
        else
        {
            Debug.LogWarning("DataManager instance is null!");
        }
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        if (DataManager.Instance != null)
        {
            DataManager.Instance.SaveScore();
        }
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
