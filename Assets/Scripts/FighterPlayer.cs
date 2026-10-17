using UnityEngine;

public class Fighter : Player
{       
    void OnTriggerEnter(Collider other)
    {
        // 1. Get the class reference from the other object
        Player FighterHP = other.GetComponent<Player>();
            // 2. Update the parameter on that class instance
            FighterHP.hp= 5; 
    }

    public Animator animator;

    public Transform attackPoint;

    public float attackRange = 0.5f;

    public LayerMask enemyLayers;

    public int attackDamage = 40;

    public float attackRate = 2f; 

    float nextAttackTime = 0f;

//TODO - add attack function

void Update()
{
    if(Time.time >= nextAttackTime)
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
             Attack();
             nextAttackTime = Time.time + 1f / attackRate;
        }

    }
    
} 

public override void Attack()
{
    animator.SetTrigger("Attack");

    Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

    foreach(Collider2D enemy in hitEnemies)
    {
        enemy.GetComponent<EnemySword>().TakeDamage(attackDamage);
        Debug.Log("We hit" + enemy.name);
    }

    Debug.Log("Attack like a swordsman!");
}
    
void OnDrawGizmosSelected()
{
    if (attackPoint == null)
        return;

    Gizmos.DrawWireSphere(attackPoint.position, attackRange);
}

public void TakePlayerDamage(int damage)
    {
        HP -= damage;
        Debug.Log("Player got hit! Current HP: " + HP);

        if (HP <= 0)
        {
            Die();
        }

        else
        {
            animator.SetTrigger("Fighter_block");
        }
    }
//TODO - add diying function
    public override void Die()
    {
        Debug.Log("I'm dead like a knight!");

        animator.SetTrigger("Fighter_die");
        
        //GetComponent<Collider2D>().enabled = false;
        GetComponent<Rigidbody2D>().simulated = false;

        GetComponent<PlayerMovement>().enabled = false;

        this.enabled = false; 

        Invoke("ShowGameOverScreen", 1.5f);
        
    }

    void ShowGameOverScreen()
        {
        base.Die(); 
        this.enabled = false;
        
        
        } 






// //TODO - add getting damage function
//     public virtual int GetDamage(int hit)
//     {
//         Debug.Log("I've been hit!");
//         int updatetHP = this.hp - hit;
//         Debug.Log($"my current HP is: {updatetHP}");
//         return updatetHP;
//     }

    // public virtual void Move()
    // {
    //     Debug.Log("I'm moving, I'm moving!");
    // }
    
// TODO - enable item pickup. Could be temp effect (speed / hp / stamina),
// or could be permenant effect (sword / wings / spiky armor)
    // public virtual void PickUpItem()
    // {
    //     Debug.Log("Got a cool new item!");
    // }

//TODO - add special ability function. Has to do with available stamina.
    public override void SpecialAbility()
    {
        Debug.Log("I'm gonna cut you, son");
    }

}
