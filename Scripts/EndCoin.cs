using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCoin : MonoBehaviour
{
    public AudioSource win;
    public PlayerValues stats;
    public GameObject endScreen;
    public GameObject coin;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Cursor.visible = true;
            win.Play();
            Time.timeScale = 0f;

            stats.canOpenMenu = false;
            endScreen.SetActive(true);
            coin.SetActive(false);
        }
    }
}
