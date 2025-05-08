using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[System.Serializable]
public class GameData
{
    public int currency;

    public SerializableDictionary<string, int> inventory;
    public List<string> equipmentId;

    public GameData()
    {
        this.currency = 0;
        inventory = new SerializableDictionary<string, int>();
        equipmentId = new List<string>();
    }
}
