using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    private string player;

    private Player1Controller P1Controller;
    private Player2Controller P2Controller;
    public GameMaster GM;

    private int powerUp;

    private void Awake()
    {
        GM = FindObjectOfType<GameMaster>();
        P1Controller = FindObjectOfType<Player1Controller>();
        P2Controller = FindObjectOfType<Player2Controller>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player1") || other.CompareTag("Player2"))
        {         
            player = other.tag;

            //Give 1 random powerup
            powerUp = Random.Range(0, 3);
            if(powerUp == 0)
            {
                Debug.Log("Heal");
                Heal();
            }
            else if (powerUp == 1)
            {
                Debug.Log("AttackBuff");
                AttackBuff();
            }
            else if (powerUp == 2)
            {
                Debug.Log("MoveSpeed");
                MoveSpeed();
            }
            else if (powerUp == 3)
            {
                Debug.Log("AttackRange");
                AttackRange();
            }          
            Destroy(gameObject);
        }
    }


    public void Heal()
    {
        if(player == ("Player1"))
        {
            GM.p1Health += 20;
        }
        else if (player == ("Player2"))
        {
            GM.p2Health += 20;
        }
        
    }

    public void AttackBuff()
    {
        if (player == ("Player1"))
        {
           P1Controller.attackDamage += 10;
        }
        else if (player == ("Player2"))
        {
            P2Controller.attackDamage += 10;
        }
    }

    public void MoveSpeed()
    {
        if (player == ("Player1"))
        {
            P1Controller.movementSpeed += 3;
        }
        else if (player == ("Player2"))
        {
            P1Controller.movementSpeed += 3;
        }
    }

    public void AttackRange()
    {
        if (player == ("Player1"))
        {
            P1Controller.attackRange += 0.1f;
        }
        else if (player == ("Player2"))
        {
            P1Controller.attackRange += 0.1f;
        }
    }

}

