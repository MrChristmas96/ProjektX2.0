using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMaster : MonoBehaviour
{

    public Text p1PointsUI;
    public Text p2PointsUI;

    public Image P1Flash;
    public Image P2Flash;

    public GameMaster gameMaster;

    private void Start()
    {
        P1Flash.enabled = false;
        P2Flash.enabled = false;
    }

    void Update()
    {
        p1PointsUI.text = "Player 1 points: "+ gameMaster.p1Points;
        p2PointsUI.text = "Player 2 points: " + gameMaster.p2Points;
    }

    public void ReactorDamageFlashP1()
    {
        //Play Animation

    }
    public void ReactorDamageFlashP2()
    {
        //Play Animation
    }

}
