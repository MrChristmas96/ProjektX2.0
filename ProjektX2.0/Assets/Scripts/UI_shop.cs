using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_shop : MonoBehaviour
{

    private void Awake()
    {
        HideP1();
        HideP2();
    }

    public void ShowP1()
    {
        gameObject.SetActive(true);
    }

    public void HideP1()
    {
<<<<<<< Updated upstream
        Transform shopItemTransform = Instantiate(ShopItemTemplate, Container);
        shopItemTransform.gameObject.SetActive(true);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 30f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("ItemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("CostPrice").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("ItemImage").GetComponent<Image>().sprite = itemSprite;



=======
        gameObject.SetActive(false);
>>>>>>> Stashed changes
    }

    public void ShowP2()
    {
        gameObject.SetActive(true);
    }

    public void HideP2()
    {
        gameObject.SetActive(false);
    }
}
