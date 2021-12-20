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

    [SerializeField] private Text yetiCostP1;
    [SerializeField] private RectTransform spawnYetiP1;
    [SerializeField] private Text stunCostP1;
    [SerializeField] private RectTransform stunYetiP1;
    [SerializeField] private Text yetiCostP2;
    [SerializeField] private RectTransform spawnYetiP2;
    [SerializeField] private Text stunCostP2;
    [SerializeField] private RectTransform stunYetiP2;

    private void Start()
    {
        anim = GetComponent<Animator>();
        yetiCostP1 = spawnYetiP1.GetComponent<Text>();
        stunCostP1 = stunYetiP1.GetComponent<Text>();
        yetiCostP2 = spawnYetiP2.GetComponent<Text>();
        stunCostP2 = stunYetiP2.GetComponent<Text>();
    }

    void Update()
    {
        p1PointsUI.text = "Player 1 points: " + gameMaster.p1Points;
        p2PointsUI.text = "Player 2 points: " + gameMaster.p2Points;
        WaveCount.text = "Wave: " + gameMaster.waveCount;

        yetiCostP1.text = "" + gameMaster.p1Points;
        stunCostP1.text = "10";
        yetiCostP2.text = "" + gameMaster.p2Points;
        stunCostP2.text = "10";
    }

    public void ReactorDamageFlashP1()
    {
        anim.Play("P1ReactorDamage");

    }
    public void ReactorDamageFlashP2()
    {
        anim.Play("P2ReactorDamage");
    }

    public void WaveStart()
    {
        anim.Play("WaveStart");
    }
}
