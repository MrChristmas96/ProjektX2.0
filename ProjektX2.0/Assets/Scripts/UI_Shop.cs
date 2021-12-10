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
        shopItemTemplate = Container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        CreateItemButton(spawnitem.GetSprite(spawnitem.ItemType.SpawnYeti), "SpawnYeti", spawnitem.GetCost(spawnitem.ItemType.SpawnYeti),1);

        
    }

    private void CreateItemButton(Sprite itemSprite, string itemName, int itemCost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, Container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 30f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("itemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("CostText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("itemImage").GetComponent<Image>().sprite = itemSprite;
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
    
 