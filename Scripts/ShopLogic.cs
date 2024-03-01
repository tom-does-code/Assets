using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class ShopLogic : MonoBehaviour
{
    GameObject shopUI;
    public string itemName;
    public string itemDescription;
    public int itemPrice;

    public bool ownsItem;

    GameObject objectParent;
    GameObject data;
    GameObject buttonTitle;
    GameObject buttonDescription;
    GameObject buttonPrice;

    GameObject confirmCanvas;
    GameObject confirmItemTitle;
    GameObject confirmDescription;
    GameObject confirmButton;

    public PlayerValues playerStats;

    public int currentPrice;
    public bool ingameValue;

    void Start()
    {
        ownsItem = false;

        objectParent = transform.parent.gameObject;
        data = objectParent.transform.Find("Data").gameObject;

        ingameValue = data.GetComponent<ShopLogic>().ownsItem;

        buttonTitle = objectParent.transform.Find("Title").gameObject;
        buttonDescription = objectParent.transform.Find("Description").gameObject;
        buttonPrice = objectParent.transform.Find("Price").gameObject;

        shopUI = objectParent.transform.parent.gameObject;

        confirmCanvas = transform.parent.parent.Find("ConformationTab").gameObject;
        confirmButton = confirmCanvas.transform.Find("PurchaseButton").gameObject;

        confirmButton.GetComponent<Button>().onClick.AddListener(ConfirmClick);


        string titleText = data.GetComponent<ShopLogic>().itemName;
        string descriptionText = data.GetComponent<ShopLogic>().itemDescription;
        int itemPrice = data.GetComponent<ShopLogic>().itemPrice;

        buttonTitle.GetComponent<TextMeshProUGUI>().text = titleText;
        buttonDescription.GetComponent<TextMeshProUGUI>().text = descriptionText;
        buttonPrice.GetComponent<TextMeshProUGUI>().text = itemPrice.ToString();
    }

    public void itemClick()
    {
        int itemPrice = data.GetComponent<ShopLogic>().itemPrice;
        string itemName = data.GetComponent<ShopLogic>().itemName;
        string itemDescription = data.GetComponent<ShopLogic>().itemDescription;
        int playerCoins = playerStats.Cash;

        if (playerCoins >= itemPrice)
        {
            Confirm(itemPrice, itemName, itemDescription);
        }
        else
        {
            Debug.Log("Insufficient coins.");
        }
    }
    public void Confirm(int price, string itemName, string itemDescription)
    {
        currentPrice = price;
        confirmItemTitle = confirmCanvas.transform.Find("ItemTitle").gameObject;
        confirmDescription = confirmCanvas.transform.Find("ItemDescription").gameObject;

        confirmItemTitle.GetComponent<TextMeshProUGUI>().text = itemName;
        confirmDescription.GetComponent<TextMeshProUGUI>().text = itemDescription;
        confirmCanvas.transform.SetParent(transform.parent);
        confirmCanvas.SetActive(true);

        Debug.Log("Values: " + itemName + currentPrice);
    }

    public void ConfirmClick()
    {
        ingameValue = true;
        playerStats.Cash -= currentPrice;
        confirmCanvas.transform.SetParent(shopUI.transform);
        confirmCanvas.SetActive(false);

        currentPrice = 0;
    }
}