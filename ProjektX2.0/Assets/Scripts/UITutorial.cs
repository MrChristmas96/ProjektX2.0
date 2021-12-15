using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITutorial : MonoBehaviour
{

    public Text points;

    private Animator anim;

    public GameMaster gameMaster;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        int totalPoints = gameMaster.p1Points + gameMaster.p2Points;
        points.text = "Points: " + totalPoints;
    }

}
