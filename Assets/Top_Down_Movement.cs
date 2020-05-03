using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_Down_Movement : MonoBehaviour
{
    public Animator animator;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private bool facingRight = true;

    public bool canMove;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canMove = true;
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        if(!canMove)
        {
            rb.velocity = Vector2.zero;
            return;
        }
    }

    void FixedUpdate()
    {
        animator.SetFloat("Speed", Mathf.Abs(moveVelocity.sqrMagnitude));
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        if (facingRight == false && moveVelocity.x > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveVelocity.x < 0)
        {
            Flip();
        }
        
    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);


    }
}
