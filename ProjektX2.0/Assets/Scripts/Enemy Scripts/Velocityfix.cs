using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocityfix : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        rb =  GetComponent<Rigidbody2D>();

        Vector2 direction = new Vector2( Random.Range(-4f, 4f),  Random.Range(3f, 5f));
        rb.velocity = direction*10;
    }
}
