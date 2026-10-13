using UnityEngine;

public class Fighter : Player
<<<<<<< HEAD
{

//TODO - add attack function
=======
{       
    void OnTriggerEnter(Collider other)
    {
        // 1. Get the class reference from the other object
        Player FighterHP = other.GetComponent<Player>();
            // 2. Update the parameter on that class instance
            FighterHP.hp= 5; 
    }

    
    
    
     //TODO - add attack function
>>>>>>> lia-branch-merged-may
    public override void Attack()
    {
        Debug.Log("Attack like a swordsman!");
    }

//TODO - add diying function
    public override void Die()
    {
<<<<<<< HEAD
=======
        base.Die();
>>>>>>> lia-branch-merged-may
        Debug.Log("I'm dead like a knight!");
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

<<<<<<< HEAD
    void Start()
    {
        hp = GetDamage(4);
    }
    
=======
>>>>>>> lia-branch-merged-may
}
