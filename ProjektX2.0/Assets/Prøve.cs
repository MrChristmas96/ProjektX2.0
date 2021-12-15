using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;
using System;

public class Prøve : MonoBehaviour
{

    void Start()
    {

        
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            
            GetComponent<Player1Controller>().enabled = false;
            StartCoroutine(Waiter());
        }

        
    }




    IEnumerator Waiter()
    {

        Debug.Log("hhhh");
        yield return new WaitForSecondsRealtime(3);

        GetComponent<Player1Controller>().enabled = true;


    }


}
