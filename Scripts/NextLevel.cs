using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public PlayerValues Stats;
    public Transform player;
    public Camera cam;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Stats.Level == 1)
            {
                Stats.Level = 2;
                player.position = Stats.lev2Start;
                cam.orthographicSize = Stats.lev2CamSize;
                cam.transform.position = Stats.lev2CamPos;
            }
            else
            {
                if (Stats.Level == 2)
                {
                    Stats.Level = 3;
                    player.position = Stats.lev3Start;
                    cam.orthographicSize = Stats.lev3CamSize;
                    cam.transform.position = Stats.lev3CamPos;
                }
            }
        }
    }
}
