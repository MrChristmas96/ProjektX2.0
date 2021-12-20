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
<<<<<<< Updated upstream
            waveSpawner.enemyP1 += gameMaster.p1Points;
            gameMaster.p1Points = 0;
            
=======
            playerRb = collision.GetComponent<Rigidbody2D>();
            player = "P1";
        }
        else if (collision.CompareTag("Player2"))
        {
            player = "P2";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        player = "P0";
    }

    public void Send()
    {
        if (player == null || player =="P0")
        {
            Debug.Log("No player Chosen");
        }
        else if (player == "P1")
        {
            waveSpawner.enemyP1 += gameMaster.p1Points;
            gameMaster.p1Points = 0;
>>>>>>> Stashed changes
        }
        else if (collision.CompareTag("Player2"))
        {
            waveSpawner.enemyP2 += gameMaster.p2Points;
            gameMaster.p2Points = 0;
<<<<<<< Updated upstream
=======
        }

    }

    public void Stun()
    {

        if (player == null || player == "P0")
        {
            Debug.Log("No player Chosen");
>>>>>>> Stashed changes
        }

    }
}
