using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTriggerCollider : MonoBehaviour
{

    [SerializeField] private UI_shop uiShop;
    private void OnTriggerEnter2D(collider2D collider)
    {
        IshopCustomer shopCustomer = collider.GetComponent<IShopCustomer>();
        if (shopCustomer !=null)
        {
            uiShop.Show(showCustomer);

        }
    }
    private void OnTriggerEnter2D(Collider2D colliDER) 
    {
        IShopCustomer shopCustomer = collider.GetComponent<IShopCustomer>();
        if (shopCustomer !=null) {
            uiShop.Hide();
        
    }
}

        
