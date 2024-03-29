using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class EnemyController : MonoBehaviour
{
    public GameMaster gameMaster;

    private Transform p1;
    private Transform p1House;
    private Transform p2;
    private Transform p2House;
    private Transform target;

    public float speed;
    public float StoppingDistance;

    public LayerMask playerLayer;
    public float attackDamage = 10f;
    [SerializeField] private float attackSpeed = 20f;
    private float CanAttack;

    public Transform attackPoint;
    public float attackRange = 0.5f;

    public GameObject pointDrop;
    public GameObject powerUp;

    public float currentEnemyHealth;

    public ParticleSystem hit;
    public ParticleSystem blood;
    private ParticleSystem hitPlay;
    private ParticleSystem bloodPlay;
    public ParticleSystem deathBlood;
    private ParticleSystem deathBloodPlay;

    public GameObject deadBody;
    private Transform[] deadBodyParts;
    private Vector2 position;

    private Animator anim;

    private void Awake()
    {
        gameMaster = FindObjectOfType<GameMaster>();

        p1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Transform>();
        p1House = GameObject.FindGameObjectWithTag("P1House").GetComponent<Transform>();
        p2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Transform>();
        p2House = GameObject.FindGameObjectWithTag("P2House").GetComponent<Transform>();

        anim = GetComponent<Animator>();

        if (transform.position.y >= 0)
        {
            target = p1House;
        }
        else if (transform.position.y < 0)
        {
            target = p2House;
        }

        hitPlay = null;
        bloodPlay = null;
        deathBloodPlay = null;

        deadBodyParts = deadBody.GetComponentsInChildren<Transform>();

    }

    private void Update()
    {

        //move to player
        if (Vector2.Distance(transform.position, p1.position) < StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, p1.position, speed * Time.deltaTime);
            
            //Flip Player mod spiller
            if (p1.transform.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(0.4f, 0.4f, 1f);
            }
            else
            {
                transform.localScale = new Vector3(-0.4f, 0.4f, 1f);
            }
        }
        else if (Vector2.Distance(transform.position, p2.position) < StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, p2.position, speed * Time.deltaTime);

            if (p2.transform.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(0.4f, 0.4f, 1f);
            }
            else
            {
                transform.localScale = new Vector3(-0.4f, 0.4f, 1f);
            }
        }

        else //Move to house
        {
            if (Vector2.Distance(transform.position, target.position) > 2.5)
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            FlipEnemy();
        }

            if (currentEnemyHealth <= 0)
        {
            gameObject.SetActive(false);
        }
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player1" || other.gameObject.tag == "Player2")
        {

            if (attackSpeed <= CanAttack)
            {

                anim.Play("YetiAttack1");
                CanAttack = 0f;
            }
            else
            {
                CanAttack += Time.deltaTime;

            }
        }

        if (other.gameObject.tag == "P1House" || other.gameObject.tag == "P2House")
        {
            if (attackSpeed <= CanAttack)
            {
                anim.Play("YetiAttack1");
                CanAttack = 0f;
            }
            else
            {
                CanAttack += Time.deltaTime;
            }
        }
    }

    //Bliver kaldt af en event i YetiAttack1 I Animation Unity
    private void Attack()
    {
        
       Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);


        for (int i = 0; i < hitPlayer.Length; i++)
        {


            if (hitPlayer[i].tag == "Player1")
            {
                gameMaster.P1takeDamage(attackDamage * 2);
            }

            else if (hitPlayer[i].tag == "Player2")
            {
                gameMaster.P2takeDamage(attackDamage * 2);
            }
                            
            else if (hitPlayer[i].tag == "P1House")
            {
                gameMaster.P1HousetakeDamage(attackDamage);
            }

            else if (hitPlayer[i].tag == "P2House")
            {
                gameMaster.P2HousetakeDamage(attackDamage);
            }
                
        }
      
    }

    
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
    
    void FlipEnemy()
    {
        //Flip Enemy mod hus
        if (target.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(0.4f, 0.4f, 1f);
        }
        else
        {
            transform.localScale = new Vector3(-0.4f, 0.4f, 1f);
        }
    }

    //Disable og ikke destroy s� vi kan efterlade lig p� banen.
    private void OnDisable()
    {
        // Fixer error "Some objects were not cleaned up when closing the scene" s� den kun instantiater hvis scener er loaded
        if (!this.gameObject.scene.isLoaded) return;
        Instantiate(pointDrop, transform.position, Quaternion.identity);


        DeathBlood(deathBlood);


        int rand = Random.Range(0, 100);
        if (rand <= 10)
        {
            Instantiate(powerUp, transform.position, Quaternion.identity);
        }
        
        for(int i = 0; i < deadBodyParts.Length; i++)
        {
            position = new Vector2(transform.position.x + Random.Range(-5f, 5f), transform.position.y + Random.Range(-5f, 5f));
            Instantiate(deadBodyParts[i], position, Quaternion.identity);
  
        }

        
    }

    public void TakeDamage(float f)
    {
        transform.position = transform.position + new Vector3(0, 1, 0);
        HitEffect(hit);
        BloodEffect(blood);
        currentEnemyHealth -= f;
        Thread.Sleep(20);
    }
    
    public void HitEffect(ParticleSystem hit)
    {
        //Gemmer hit particleSystem som en variabel
        if (hitPlay == null)
        {
            hitPlay = Instantiate(hit, transform.position, Quaternion.identity);
        }
        hitPlay.Play();
    }

    public void BloodEffect(ParticleSystem blood)
    {
        if (bloodPlay == null)
        {
            bloodPlay = Instantiate(blood, transform.position, Quaternion.identity);
        }
        bloodPlay.Play();
    }

    public void DeathBlood(ParticleSystem deathBlood)
    {
        if (deathBloodPlay == null)
        {
            deathBloodPlay = Instantiate(blood, transform.position, Quaternion.identity);
        }
        deathBloodPlay.Play();
    }
}
