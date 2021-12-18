using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShopTrigger : MonoBehaviour
{

    [SerializeField] private UI_shop uiShop;


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player1"))
        {
            IShopCustomer shopCustomer = collider.GetComponent<IShopCustomer>();
            uiShop.Show(shopCustomer);
        }

        else if (collider.CompareTag("Player2"))
        {

        }

    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        
        if (collider.CompareTag("Player1"))
        {
            IShopCustomer shopCustomer = collider.GetComponent<IShopCustomer>();
            uiShop.Hide();
        }
        else if (collider.CompareTag("Player2"))
        {

        }
    }
}
