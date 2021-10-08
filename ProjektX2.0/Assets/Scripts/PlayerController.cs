using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float jumpSpeed;
    public LayerMask Ground;

    private PlayerActionControls player1ActionControls;
    private Rigidbody2D rb;
    private Collider2D col;

    private void Awake()
    {
        player1ActionControls = new PlayerActionControls();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    private void OnEnable()
    {
        player1ActionControls.Enable();
    }

    private void OnDisable()
    {

    }
    void Start()
    {
        player1ActionControls.Player1.Jump.performed += _ => Jump();
    }

    private void Jump()
    {
        if (IsGrounded())
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }
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
    void Update()
    {
        //Read movement value
        float movementInput = player1ActionControls.Player1.Move.ReadValue<float>();

        //Move player
        Vector3 currentPosition = transform.position;
        currentPosition.x += movementInput * movementSpeed * Time.deltaTime;
        transform.position = currentPosition;
    }
}
