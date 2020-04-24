using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_attack : MonoBehaviour
{
    private float timeBetweenAttack;
    private float startTimeAttack;

    public Animator animator;

    public Transform attackPoint;
    public float attackRange;
    public LayerMask EnemyLayers;

    public int damageNum = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
            Collider2D[] enemyToDamage = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, EnemyLayers);
            foreach(Collider2D enemy in enemyToDamage)
            {
                enemy.GetComponent<Enemy_health>().TakeDamage(damageNum);
            }
        }
    }


    void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
