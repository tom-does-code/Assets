using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManageStatsUI : MonoBehaviour
{
    public TMP_Text levelText;
    public TMP_Text coinsText;
    public PlayerValues stats;
    void Update()
    {
        levelText.text = "LEVEL " + stats.Level;
        coinsText.text = "COINS: " + stats.Cash;
    }
}
