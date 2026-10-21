using UnityEngine;

public class EnemySword : MonoBehaviour
{

    public Animator animator;
    
    public int maxHealth = 100;
    int currentHealth;

    public Transform attackPoint;

    public float attackRange = 0.5f;

    public int attackDamage = 40;

    public float attackRate = 2f; 

    float nextAttackTime = 0f;

    public Transform player; 
    public LayerMask playerLayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        animator.SetTrigger("Hurt");

        if(currentHealth <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Debug.Log("Enemy died!");

        animator.SetBool("Isdead", true);

        GetComponent<Collider2D>().enabled = false;

        this.enabled = false;
    }


void Update()
    {
        if (player == null) return;

      
        if (Time.time >= nextAttackTime)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);

            
            if (distanceToPlayer <= attackRange)
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        animator.SetBool("IsAttack", true); 
        Invoke("ResetAttackAnimation", 0.5f);

        Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);

        foreach(Collider2D hitPlayer in hitPlayers)
        {
            Player playerScript = hitPlayer.GetComponent<Player>();
            if (playerScript != null)
            {
                playerScript.TakePlayerDamage(attackDamage);
            }
        }
    }

    void ResetAttackAnimation()
    {

    animator.SetBool("IsAttack", false);
    
    }

  
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null) return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

