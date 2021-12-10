using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player1 : MonoBehaviour, IShopCustomer
{

    public static Player1 Instance { get; private set; }

    public event EventHandler OnGoldAmountChanged;
    public event EventHandler OnHealthPotionAmountChanged;

    public void BoughtItem(spawnitem.ItemType itemType)
    {
        throw new NotImplementedException();
    }

}
