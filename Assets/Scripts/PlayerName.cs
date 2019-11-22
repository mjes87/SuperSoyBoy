using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    private InputField input;
    void Start()
    {
        // 1
        input = GetComponent<InputField>();
        input.onValueChanged.AddListener(SavePlayerName);
        // 2
        var savedName = PlayerPrefs.GetString("PlayerName");
        if (!string.IsNullOrEmpty(savedName))
        {
            input.text = savedName;
            GameManager.instance.playerName = savedName;
        }
    }
    private void SavePlayerName(string playerName)
    {
        // 3
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();
        GameManager.instance.playerName = playerName;
    }
}
