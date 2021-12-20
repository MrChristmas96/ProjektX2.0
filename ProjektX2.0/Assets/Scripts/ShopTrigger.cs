using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShopTrigger : MonoBehaviour
{

    [SerializeField] private UI_shop uiShop;


    private void OnTriggerEnter2D(Collider2D collider)
    {
<<<<<<< Updated upstream
        IShopCustomer shopCustomer = collider.GetComponent<IShopCustomer>();
        uiShop.Show(shopCustomer);
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        IShopCustomer shopCustomer = collider.GetComponent<IShopCustomer>();     
        uiShop.Hide();
=======
        if (collider.CompareTag("Player1"))
        {
            uiShop.ShowP1();
        }

        else if (collider.CompareTag("Player2"))
        {
            uiShop.ShowP2();
        }

    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        
        if (collider.CompareTag("Player1"))
        {
            uiShop.HideP1();
        }
        else if (collider.CompareTag("Player2"))
        {
            uiShop.HideP2();
        }
>>>>>>> Stashed changes
    }
}
