using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenUI : MonoBehaviour
{
    public GameObject[] coinsToActivate;
    public GameObject player;
    public Camera cam;
    public GameObject endScreen;
    public PlayerValues stats;

    public void Restart()
    {
        stats.Level = 1;
        stats.Cash = 0;
        Cursor.visible = false;
        foreach (GameObject obj in coinsToActivate)
        {
            obj.SetActive(true);
        }
        player.transform.position = stats.lev1Start;
        cam.transform.position = stats.lev1CamPos;
        cam.orthographicSize = stats.lev1CamSize;

        stats.canOpenMenu = true;
        endScreen.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
