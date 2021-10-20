using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEnemy : MonoBehaviour
{

    public WaveSpawner waveSpawner;
    public GameMaster gameMaster;

    private void Start()
    {
        waveSpawner = FindObjectOfType < WaveSpawner >();
        gameMaster = FindObjectOfType<GameMaster>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            waveSpawner.enemyP1 = gameMaster.p1Points;
            gameMaster.p1Points = 0;
            
        }
        else if (collision.CompareTag("Player2"))
        {
            waveSpawner.enemyP2 = gameMaster.p2Points;
            gameMaster.p2Points = 0;
        }

    }
}
