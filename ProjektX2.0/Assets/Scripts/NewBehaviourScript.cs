using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Ss;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            Ss.SetActive(true);
            
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

            Ss.SetActive(false);
        
    }
}
