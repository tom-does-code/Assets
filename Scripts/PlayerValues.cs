using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerValues : MonoBehaviour
{
    public int Level;
    public int Score;
    public int Cash;
    public bool canOpenMenu;

    public Vector3 lev1Start;
    public Vector3 lev2Start;

    public Vector3 lev1CamPos;
    public float lev1CamSize;
    public Vector3 lev2CamPos;
    public float lev2CamSize;

    public Vector3 lev3Start;
    public Vector3 lev3CamPos;
    public float lev3CamSize;
    void Start()
    {
        canOpenMenu = true;
        Level = 1;
        Score = 0;
        Cash = 100;
        lev2Start = new Vector3(41.55f, -0.92f, 0f);
        lev2CamPos = new Vector3(61.27f, 0, -20f);
        lev2CamSize = 12f;

        lev1Start = new Vector3(-14.29f, -0.92f, 0);
        lev1CamPos = new Vector3(0.08f, 0f, -20f);
        lev1CamSize = 9.1f;

        lev3Start = new Vector3(-26.93f, -38.26f, 0);
        lev3CamPos = new Vector3(-0.6f, -29.7f, -20f);
        lev3CamSize = 15.54f;
    }
}
