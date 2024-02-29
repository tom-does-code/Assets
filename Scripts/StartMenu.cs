using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Button playButton;

    public void playClick()
    {
        SceneManager.LoadScene("MainGame");
    }
}
