using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopHandler : MonoBehaviour
{
    public GameObject pMenu;
    public GameObject shopUI;
    public PlayerValues plrValues;
    public void shopClick()
    {
        pMenu.SetActive(false);
        shopUI.SetActive(true);
        plrValues.canOpenMenu = false;
    }

    public void exitClick()
    {
        shopUI.SetActive(false);
        pMenu.SetActive(true);
        plrValues.canOpenMenu = true;
    }
}
