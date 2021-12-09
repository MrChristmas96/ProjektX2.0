using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnitem { 

    public enum ItemType
    {
        SpawnYeti
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

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
