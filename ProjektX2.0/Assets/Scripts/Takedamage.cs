using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takedamage : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D col)
    {
        HealthBarScript.health -= 10f;
    }
}
