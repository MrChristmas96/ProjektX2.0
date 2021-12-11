using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMaster : MonoBehaviour
{

    public Text p1PointsUI;
    public Text p2PointsUI;
    public Text WaveCount;

    public Transform wave;

    private Animator anim;

    public Image P1Flash;
    public Image P2Flash;

    public GameMaster gameMaster;
    public WaveSpawner waveSpawner;

    private void Start()
    {
        P1Flash.enabled = false;
        P2Flash.enabled = false;

        anim = GetComponent<Animator>();
    }

    void Update()
    {
        p1PointsUI.text = "Player 1 points: " + gameMaster.p1Points;
        p2PointsUI.text = "Player 2 points: " + gameMaster.p2Points;
        WaveCount.text = "Wave: " + waveSpawner.waveCount;
    }

    public void ReactorDamageFlashP1()
    {
        //Play Animation

    }
    public void ReactorDamageFlashP2()
    {
        //Play Animation
    }

    public void WaveStart()
    {
        anim.Play("WaveStart");
    }
}
