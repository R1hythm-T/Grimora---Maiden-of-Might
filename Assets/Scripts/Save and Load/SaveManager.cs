using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private GameData gameData;

    public static SaveManager instance;

    private void Awake()
    {
        if (instance != null)
            Destroy(instance.gameObject);
        else
            instance = this;
    }

    private void Start()
    {
        LoadGame();
    }

    public void NewGame()
    {
        gameData = new GameData();
    }

    public void LoadGame()
    {
        //game data from data handler

        if (this.gameData == null)
        {
            Debug.Log("No saved data found!");
            NewGame();
        }
    }

    public void SaveGame()
    {
        //data handler save game data

        Debug.Log("Game was saved!");
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }
}
