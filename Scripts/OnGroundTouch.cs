using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnGroundTouch : MonoBehaviour
{
    public int Respawn;
    public Canvas deathCanvas;
    public Canvas statsUI;

    public Movement movement;
    public PlayerValues stats;

    void Start()
    {
        deathCanvas.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            stats.canOpenMenu = false;
            movement.isAlive = false;
            statsUI.gameObject.SetActive(false);
            deathCanvas.gameObject.SetActive(true);
            Debug.Log('a');
            if (Cursor.visible == false)
            {
                Cursor.visible = true;
            }
        }
    }
}
