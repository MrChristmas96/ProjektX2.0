using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_follow : MonoBehaviour
{
    public float speed;
    public float StoppingDistance;
    private Transform target;
    private Transform target1;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    

    // Update is called once per frame
    void Update()
    {

        if(Vector2.Distance(transform.position, target.position) < StoppingDistance)
        {
           transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            if(Vector2.Distance(transform.position, target1.position) > 2.5)
            transform.position = Vector2.MoveTowards(transform.position, target1.position, speed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        target1 = GameObject.FindGameObjectWithTag("house").GetComponent<Transform>();
    }
}
