using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnitem { 

    public enum ItemType
    {
        SpawnYeti,
        StunPlayer
    }

    public static int GetCost(ItemType itemType)
    {
        switch (itemType)
        {
            default:
            case ItemType.SpawnYeti:    return 1;
            case ItemType.StunPlayer:   return 10;
        }
    }

    public static Sprite GetSprite(ItemType itemType)
    {
        switch (itemType)
        {
            default:
            case ItemType.SpawnYeti:     return GameAssets.i.Y_SpawnYeti;
            case ItemType.StunPlayer:    return GameAssets.i.Y_StunPlayer;
        }
    }
}
