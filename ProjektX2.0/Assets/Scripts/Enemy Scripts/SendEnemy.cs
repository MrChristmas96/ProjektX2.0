using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SendEnemy : MonoBehaviour
{

    public WaveSpawner waveSpawner;
    public GameMaster gameMaster;
    public string player;
    private Rigidbody2D playerRb;
    private Player1Controller p1Controller;
    private Player2Controller p2Controller;

    private float p1MaxMovementSpeed;
    private float p1MaxJumpSpeed;
    private float p2MaxMovementSpeed;
    private float p2MaxJumpSpeed;

    private int stunPrice = 10;

    private void Start()
    {
        waveSpawner = FindObjectOfType <WaveSpawner>();
        gameMaster = FindObjectOfType<GameMaster>();
        p1Controller = FindObjectOfType<Player1Controller>();
        p2Controller = FindObjectOfType<Player2Controller>();

    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player1"))
        {
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
            if(gameMaster.p1Points >= 5)
            {
                waveSpawner.enemyP1 += 5;
                gameMaster.p1Points -= 5;
            }
        }
        else if (player == "P2")
        {
            if (gameMaster.p2Points >= 5)
            {
                waveSpawner.enemyP2 += 5;
                gameMaster.p2Points -= 5;
            }
        }
    }

    public void Stun()
    {

        if (player == null || player == "P0")
        {
            Debug.Log("No player Chosen");
        }
        else if (player == "P1")
        {
            if(gameMaster.p1Points >= stunPrice)
            {
                gameMaster.p1Points -= stunPrice; 
                p2MaxMovementSpeed = p2Controller.movementSpeed;
                p2MaxJumpSpeed = p2Controller.jumpSpeed;
                StartCoroutine(StunP2());
            }
            else
            {
                Debug.Log("Not enought Points");
            }

        }

        else if (player == "P2")
        {
            if(gameMaster.p2Points >= stunPrice)
            {
                gameMaster.p2Points -= stunPrice;
                p1MaxMovementSpeed = p1Controller.movementSpeed;
                p1MaxJumpSpeed = p1Controller.jumpSpeed;
                StartCoroutine(StunP1());
            }
            else
            {
                Debug.Log("Not enought Points");
            }
        }
    }

    IEnumerator StunP2()
    {
        p2Controller.jumpSpeed = 0;
        p2Controller.movementSpeed = 0;
        yield return new WaitForSeconds(2);
        p2Controller.jumpSpeed = p2MaxJumpSpeed;
        p2Controller.movementSpeed = p2MaxMovementSpeed;
    }

    IEnumerator StunP1()
    {
        p1Controller.jumpSpeed = 0;
        p1Controller.movementSpeed = 0;
        yield return new WaitForSeconds(2);
        p1Controller.jumpSpeed = p1MaxJumpSpeed;
        p1Controller.movementSpeed = p1MaxMovementSpeed;
    }
}
