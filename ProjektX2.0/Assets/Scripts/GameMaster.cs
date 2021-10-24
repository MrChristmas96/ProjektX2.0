using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public int p1Points;
    public int p2Points;

    public int p1HouseHealth;
    public int p2HouseHealth;


    public void P1PointGain()
    {
        p1Points++;
    }

    public void P2PointGain()
    {
        p2Points++;
    }
}
