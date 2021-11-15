using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float movementSpeed;
    public float jumpSpeed;
    public LayerMask Ground;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public bool facingRight;

    public GameMaster gameMaster;

    private bool canDoubleJump = false;
    private float doubleJumpDelay = .3f;
    public float jumpTimer = 0f;
    private bool extraJumpBoost = false;

    private PlayerActionControls player1ActionControls;
    private Rigidbody2D rb;
    private Collider2D col;

    private void Awake()
    {
        player1ActionControls = new PlayerActionControls();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        gameMaster = FindObjectOfType<GameMaster>();
    }

    private void OnEnable()
    {
        player1ActionControls.Enable();
    }

    void Start()
    {
        // Tilføjer inputs
        player1ActionControls.Player1.Jump.performed += _ => Jump();
        player1ActionControls.Player1.Attack.performed += _ => Attack();
    }

    private void Jump()
    {

        if (IsGrounded())
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            jumpTimer = doubleJumpDelay;
            canDoubleJump = true;
        }
        else if (canDoubleJump && jumpTimer <=0)
        {
           
            if (extraJumpBoost)
            {
                rb.AddForce(new Vector2(0, jumpSpeed*1.8f), ForceMode2D.Impulse);
                extraJumpBoost = false;
            }
            else
            {
                rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            }
            canDoubleJump = false;
        }

    }

    private void Attack()
    {
        Debug.Log("Attacked");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers );

        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit enemy");
            enemy.GetComponent<EnemyController>().TakeDamage();
        }
    }

    //Laver en cirkel for at visualisere AttackRange
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);    
    }

    private bool IsGrounded()
    {
        // Laver en boks omkring Player for at checke om den overlapper med ground layer
        Vector2 topLeftPoint = transform.position;
        topLeftPoint.x -= col.bounds.extents.x;
        topLeftPoint.y += col.bounds.extents.y;

        Vector2 bottomRightPoint = transform.position;
        bottomRightPoint.x += col.bounds.extents.x;
        bottomRightPoint.y -= col.bounds.extents.y;

        return Physics2D.OverlapArea(topLeftPoint, bottomRightPoint, Ground);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("PointDrop"))
        {
            gameMaster.P1PointGain();
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        //Checker om player skal bruge et extra boost til jump hvis y velocity bliver for "stor"
        float velY = rb.velocity.y;
        
        
        
        if (velY < -11f)
        {
            extraJumpBoost = true;
        }
        else
        {
            extraJumpBoost = false;
        }

     
        //Read movement value
        float movementInput = player1ActionControls.Player1.Move.ReadValue<float>();


        //Flip player
        if ((movementInput < 0 && facingRight ))
        {
            facingRight = !facingRight;
            transform.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
        }
        else if (movementInput > 0 && !facingRight)
        {
            facingRight = true;
            transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        }

        //Move player
        Vector3 currentPosition = transform.position;
        currentPosition.x += movementInput * movementSpeed * Time.deltaTime;
        transform.position = currentPosition;

        if (jumpTimer > 0f)
        {
            jumpTimer -= Time.deltaTime;
        }

    }

}
