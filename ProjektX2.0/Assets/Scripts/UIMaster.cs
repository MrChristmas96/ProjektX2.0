using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMaster : MonoBehaviour
{

    public Text p1PointsUI;
    public Text p2PointsUI;

    public GameMaster gameMaster;
    
   
    void Start()
    {
       

    }

   
    void Update()
    {
        p1PointsUI.text = "Player 1 points: "+ gameMaster.p1Points;
        p2PointsUI.text = "Player 2 points: " + gameMaster.p2Points;
        
    }


}
