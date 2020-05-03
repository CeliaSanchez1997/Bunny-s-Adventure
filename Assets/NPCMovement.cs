using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;

    private Rigidbody2D rb;

    public bool isWalking;

    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;

    private int walkDirection;

    public Collider2D walkZone;
    private bool hasWalkZone;

    public bool canMove;
    private DialogManager theDM;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        theDM = FindObjectOfType<DialogManager>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();

        if (walkZone != null)
        {
            minWalkPoint = walkZone.bounds.min;
            maxWalkPoint = walkZone.bounds.max;
            hasWalkZone = true;
        }

        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(!theDM.dialogAcive)
        {
            canMove = true;
        }

        if(!canMove)
        {
            rb.velocity = Vector2.zero;
            return;
        }

            switch(walkDirection)
            {
                case 0:
                    rb.velocity = new Vector2(0,moveSpeed);
                if(hasWalkZone && transform.position.y > maxWalkPoint.y)
                {
                    isWalking = false;
                    waitCounter = waitTime;
                }
                    break;

                case 1:
                    rb.velocity = new Vector2(moveSpeed,0);
                if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                {
                    isWalking = false;
                    waitCounter = waitTime;
                }
                break;

                case 2:
                    rb.velocity = new Vector2(0, -moveSpeed);
                if (hasWalkZone && transform.position.y < minWalkPoint.y)
                {
                    isWalking = false;
                    waitCounter = waitTime;
                }
                break;

                case 3:
                    rb.velocity = new Vector2(-moveSpeed,0);
                if (hasWalkZone && transform.position.x < minWalkPoint.x)
                {
                    isWalking = false;
                    waitCounter = waitTime;
                }
                break;
            }

        if (isWalking)
        {
            walkCounter -= Time.deltaTime;
            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }

        }
        else
        {
            waitCounter -= Time.deltaTime;

            rb.velocity = Vector2.zero;

            if (waitCounter < 0)
            {
                ChooseDirection();
            }
        }
    }

    public void ChooseDirection()
    {
        walkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }

}
