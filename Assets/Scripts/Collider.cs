using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 5f;
    public LayerMask wallLayer = 1;
    public float wallCheckDistance = 0.1f;

    private Rigidbody2D rb;
    private Vector2 movement;
    private BoxCollider2D playerCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        Vector2 desiredVelocity = movement * speed;
        Vector2 adjustedVelocity = GetAdjustedVelocity(desiredVelocity);
        rb.linearVelocity = adjustedVelocity;
    }

    Vector2 GetAdjustedVelocity(Vector2 desiredVelocity)
    {
        Vector2 adjustedVelocity = desiredVelocity;

        // Check for walls in movement direction
        Vector2 currentPos = rb.position;

        // Horizontal wall check
        if (Mathf.Abs(desiredVelocity.x) > 0.1f)
        {
            Vector2 horizontalCheckPos = currentPos + Vector2.right * Mathf.Sign(desiredVelocity.x) * wallCheckDistance;
            if (Physics2D.OverlapBox(horizontalCheckPos, playerCollider.size * 0.9f, 0f, wallLayer))
            {
                adjustedVelocity.x = 0f; // Block horizontal movement
            }
        }

        // Vertical wall check
        if (Mathf.Abs(desiredVelocity.y) > 0.1f)
        {
            Vector2 verticalCheckPos = currentPos + Vector2.up * Mathf.Sign(desiredVelocity.y) * wallCheckDistance;
            if (Physics2D.OverlapBox(verticalCheckPos, playerCollider.size * 0.9f, 0f, wallLayer))
            {
                adjustedVelocity.y = 0f; // Block vertical movement
            }
        }

        return adjustedVelocity;
    }
}