using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
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

    private PlayerActionControls player2ActionControls;
    private Rigidbody2D rb;
    private Collider2D col;

    public ScreenShake screenShake;

    private Animator anim;

    private void Awake()
    {
        player2ActionControls = new PlayerActionControls();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        gameMaster = FindObjectOfType<GameMaster>();
        anim = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        player2ActionControls.Enable();
    }

    void Start()
    {
        player2ActionControls.Player2.Jump.performed += _ => Jump();
        player2ActionControls.Player2.Attack.performed += _ => Attack();
    }

    private void Jump()
    {

        if (IsGrounded())
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            jumpTimer = doubleJumpDelay;
            canDoubleJump = true;
        }
        else if (canDoubleJump && jumpTimer <= 0)
        {

            if (extraJumpBoost)
            {
                rb.AddForce(new Vector2(0, jumpSpeed * 1.8f), ForceMode2D.Impulse);
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
        anim.Play("P1Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit enemy");
            enemy.GetComponent<EnemyController>().TakeDamage();
            StartCoroutine(screenShake.Shake(0.1f, 1f));
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
        topLeftPoint.y += col.bounds.extents.y+3f;

        Vector2 bottomRightPoint = transform.position;
        bottomRightPoint.x += col.bounds.extents.x;
        bottomRightPoint.y -= col.bounds.extents.y+3f;

        return Physics2D.OverlapArea(topLeftPoint, bottomRightPoint, Ground);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("PointDrop"))
        {
            gameMaster.P2PointGain();
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
        float movementInput = player2ActionControls.Player2.Move.ReadValue<float>();

        //Flip player
        if ((movementInput < 0 && facingRight))
        {
            facingRight = !facingRight;
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (movementInput > 0 && !facingRight)
        {
            facingRight = true;
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        //Move player
        Vector3 currentPosition = transform.position;
        currentPosition.x += movementInput * movementSpeed * Time.deltaTime;
        transform.position = currentPosition;

        if (jumpTimer > 0f)
        {
            jumpTimer -= Time.deltaTime;
        }

        anim.SetFloat("Speed", Mathf.Abs(movementInput));
    }

}
