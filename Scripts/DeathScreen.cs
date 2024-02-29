using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{
    public Canvas deathCanvas;
    public Canvas statsUI;
    public Button respawnButton;
    public Movement movement;
    public PlayerValues stats;

    void Start()
    {
        respawnButton.onClick.AddListener(OnButtonPress);
    }

    void OnButtonPress()
    {
        movement.isAlive = true;
        deathCanvas.gameObject.SetActive(false);
        statsUI.gameObject.SetActive(true);
        Cursor.visible = false;
        stats.canOpenMenu = true;
        if (stats.Level == 1)
        {
            movement.transform.position = stats.lev1Start;
        };

        if (stats.Level == 2)
        {
            movement.transform.position = stats.lev2Start;
        }

        if (stats.Level == 3)
        {
            movement.transform.position = stats.lev3Start;
        }
    }
}
