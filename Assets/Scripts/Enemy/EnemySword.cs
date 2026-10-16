using UnityEngine;

public class EnemySword : MonoBehaviour
{

    public Animator animator;
    
    public int maxHealth = 100;
    int currentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        animator.SetTrigger("Enemy_block");

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
