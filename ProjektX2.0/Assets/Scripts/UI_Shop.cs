using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Shop : MonoBehaviour
{
    //Populate our store.
    private Transform Container;
    private Transform shopItemTemplate;
    private IShopCustomer shopCustomer;

    private void Awake()
    {
        Container = transform.Find("Container");
        shopItemTemplate = transform.Find("shopItemTemplat");
        
        
    }

    private void Start()
    {
       
        Hide();
       
    }


    private void CreateItemButton(Sprite itemSprite, string itemName, int itemCost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, Container);
        shopItemTransform.gameObject.SetActive(true);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 30f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("SpawnText").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("CostText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("YetiBillede").GetComponent<Image>().sprite = itemSprite;

  
    }









    private void TryBuyItem(spawnitem.ItemType itemType)
    {
        shopCustomer.BoughtItem(itemType);
   
    }

    public void Show(IShopCustomer shopCustomer)
    {
        this.shopCustomer = shopCustomer;
        gameObject.SetActive(true);

    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
  

}
    
 