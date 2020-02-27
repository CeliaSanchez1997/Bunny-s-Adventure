using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    //Health
    private float maxHealth = 100;
    public float health;
    public Text healthDisplay;
    private bool isDead = true;

    //click and drag
    private float startPoX;
    private float startPoY;
    private bool isBeingHeld = false;

    //movement
    public float speed;
    private float moveInput;

    private bool facingRight = true;

    private Rigidbody2D rb;
    //private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    // Update is called once per frame
    private void Update()
    {

        healthDisplay.text = health.ToString();

        if (isBeingHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPoX, mousePos.y - startPoY, 0);

        }
    }

    //Function for health
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(health >= maxHealth)
        {
            health = maxHealth;
            isDead = false;
            Debug.Log("Player's health is full");
        }
        else if(health <= 0)
        {
            isDead = true;
            Debug.Log("Player is dead");
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPoX = mousePos.x - this.transform.localPosition.x;
            startPoY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }

    //Function if player will turn
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

    }

}

