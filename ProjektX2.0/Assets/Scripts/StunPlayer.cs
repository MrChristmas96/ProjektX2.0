using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunPlayer : MonoBehaviour
{

    public WaveSpawner waveSpawner;
    public GameMaster gameMaster;
    


    private void Start()
    {
        waveSpawner = FindObjectOfType<WaveSpawner>();
        gameMaster = FindObjectOfType<GameMaster>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {

            Stun();


        }
        else if (collision.CompareTag("Player2"))
        {

            Stun();


        }



    }



    public void Stun()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            GetComponent<Player1Controller>().enabled = false;
            StartCoroutine(Waiter());
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            GetComponent<Player2Controller>().enabled = false;
            StartCoroutine(Waiter1());
        }

        IEnumerator Waiter()
        {

            Debug.Log("hhhh");
            yield return new WaitForSecondsRealtime(3);

            GetComponent<Player1Controller>().enabled = true;



        }

        IEnumerator Waiter1()
        {
            
            yield return new WaitForSecondsRealtime(3);

            GetComponent<Player2Controller>().enabled = true;
        }
    }



}