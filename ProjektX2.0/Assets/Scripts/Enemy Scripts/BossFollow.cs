using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFollow : MonoBehaviour
{
    public float speed;
    public float StoppingDistance;
    private Transform p1;
    private Transform p1House;
    private Transform p2;
    private Transform p2House;
    private Transform target;
    public float attackDamage = 10f;
    public float attackSpeed = 20f;
    private float CanAttack;

    // Samme som enemy follow
    void Start()
    {
        p1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Transform>();
        p1House = GameObject.FindGameObjectWithTag("P1House").GetComponent<Transform>();
        p2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Transform>();
        p2House = GameObject.FindGameObjectWithTag("P2House").GetComponent<Transform>();

        if (transform.position.y >= 0)
        {
            target = p1House;
        }
        else if (transform.position.y < 0)
        {
            target = p2House;
        }

    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player1")
        {
            if (attackSpeed <= CanAttack)
            {
                //Play Attack animation måske 1 ud af 3 tilfældige
                other.gameObject.GetComponent<Player1Controller>().UpdateHealth(-attackDamage);
                CanAttack = 0f;
            }
            else
            {
                CanAttack += Time.deltaTime;
            }
        }
    }

    void Update()
    {

        if (Vector2.Distance(transform.position, p1.position) < StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, p1.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, p2.position) < StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, p2.position, speed * Time.deltaTime);
        }
        else
        {
            if (Vector2.Distance(transform.position, target.position) > 2.5)
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

    }

}
