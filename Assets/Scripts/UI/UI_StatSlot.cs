using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_StatSlot : MonoBehaviour
{
    [SerializeField] private string statName;
    [SerializeField] private TextMeshProUGUI statValueText;
    [SerializeField] private TextMeshProUGUI statNameText;
    [SerializeField] private StatType statType;


    private void OnValidate()
    {
        gameObject.name = "Stat - " + statName;

        if (statNameText != null)
            statNameText.text = statName;
    }

    void Start()
    {
        UpdateStatValueUI();
    }

    public void UpdateStatValueUI()
    {
        PlayerStats playerStats = PlayerManager.instance.player.GetComponent<PlayerStats>();

        if (statValueText != null)
        {
            statValueText.text = playerStats.GetStat(statType).GetValue().ToString();
        }

    }
}
