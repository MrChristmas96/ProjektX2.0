using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfollow2 : MonoBehaviour
{
  public float speed;
    public float StoppingDistance;
    private Transform target;
    

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }
    

    // Update is called once per frame
    void Update()
    {
        var targetPos = new Vector2(target.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

}
