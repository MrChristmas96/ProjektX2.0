using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Shop1 : MonoBehaviour
{
    //Populate our store.
    private Transform Container;
    private Transform ShopItemTemplate;
    private IShopCustomer shopCustomer;

    private void Awake()
    {
        Container = transform.Find("Container");
       ShopItemTemplate = transform.Find("shopItemTemplat");


    }

    internal void Show(IShopCustomer shopCustomer)
    {
        throw new NotImplementedException();
    }

    private void Start()
    {

        Hide();

    }

    internal void Hide()
    {
        throw new NotImplementedException();
    }

    private void CreateItemButton(Sprite itemSprite, string itemName, int itemCost, int positionIndex)
    {
        Transform ShopItemTransform = Instantiate(ShopItemTemplate, Container);
        ShopItemTransform.gameObject.SetActive(true);
        RectTransform ShopItemRectTransform = ShopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 30f;
        ShopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        ShopItemTransform.Find("ItemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        ShopItemTransform.Find("CostText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        ShopItemTransform.Find("ItemImage").GetComponent<Image>().sprite = itemSprite;
        


        }


    }
