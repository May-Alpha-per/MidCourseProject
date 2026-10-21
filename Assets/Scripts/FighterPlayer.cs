using UnityEngine;

public class Fighter : Player
{       
    // void OnTriggerEnter(Collider other)
    // {
    //     // 1. Get the class reference from the other object
    //     Player FighterHP = other.GetComponent<Player>();
    //         // 2. Update the parameter on that class instance
    //         FighterHP.HP= 5; 
    // }

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

//TODO - add special ability function. Has to do with available stamina.
    public override void SpecialAbility()
    {
        Debug.Log("I'm gonna cut you, son");
    }

}
