using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takedamage : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player1"))
        {
            Debug.Log("Ontrigger");
        }
        HealthBarScript.health -= 10f;
    }
}
