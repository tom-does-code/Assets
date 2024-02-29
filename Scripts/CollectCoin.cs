using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public PlayerValues playerStats;
    public GameObject coin;
    public AudioSource pickup;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerStats.Cash += 1;
            coin.SetActive(false);
            pickup.Play();
        }
    }
}
