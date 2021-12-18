using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Ss;
    public GameObject Pp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            Ss.SetActive(true);
        if (Input.GetKeyDown(KeyCode.K))
        {

            GetComponent<Player1Controller>().enabled = false;
            StartCoroutine(Waiter());
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

            Ss.SetActive(false);
        
    }


    IEnumerator Waiter()
    {

        Debug.Log("hhhh");
        yield return new WaitForSecondsRealtime(3);

        GetComponent<Player1Controller>().enabled = true;


    }
}
