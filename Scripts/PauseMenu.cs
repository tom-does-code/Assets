using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject statsUI;
    public PlayerValues stats;

    void Start()
    {
        // Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && stats.canOpenMenu == true)
        {
            if (pauseMenu.activeSelf == false)
            {
                statsUI.SetActive(false);
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1f;
                pauseMenu.SetActive(false);
                Cursor.visible = false;
                statsUI.SetActive(true);
            }
        }
    }

    public void resumeButton()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Cursor.visible = false;
        statsUI.SetActive(true);
    }

    public void quitButton()
    {
        Application.Quit();
    }
}
