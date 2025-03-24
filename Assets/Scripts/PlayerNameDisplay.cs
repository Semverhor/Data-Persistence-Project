using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameDisplay : MonoBehaviour
{
    public Text playerNameText;

    // Start is called before the first frame update
    void Start()
    {
        if (DataManager.Instance != null)
        {
            playerNameText.text = "Name: " + DataManager.Instance.playerName;
        }
        else
        {
            playerNameText.text = "Name: Guest"; // Fallback if no name is set
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
