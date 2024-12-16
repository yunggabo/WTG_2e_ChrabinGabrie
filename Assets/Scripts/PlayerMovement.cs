using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float jumpSpeed = 5;
    public LayerMask groundMask;
    private Rigidbody2D rb;
    private BoxCollider2D col;
    bool isGrounded;
  

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        MoveHorizontal();

        UpdateGrounded();
        
        HandleJumping();
    }
    private void HandleJumping()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                Jump();
            }
        }
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpSpeed);
    }
    void MoveHorizontal()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
    }

    void UpdateGrounded()
    {
        isGrounded = CheckGround();
        Debug.DrawRay(transform.position, Vector3.down * (col.bounds.extents.y + 0.1f), Color.green);
    }
    bool CheckGround()
    {
        Collider2D hitCol = Physics2D.OverlapBox(transform.position + Vector3.down * 0.1f, col.bounds.size, 0, groundMask);
        if(hitCol != null)
        {
            return true;
        }
        return false;
    }
}
