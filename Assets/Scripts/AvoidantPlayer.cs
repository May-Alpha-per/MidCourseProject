using UnityEngine;

public class Avoidant : Player
{


//TODO - add diying function
    public override void Die()
    {
        Debug.Log("I'm dead like an angel!");
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
        Debug.Log("Fly high");
    }

<<<<<<< HEAD
    void Start()
    {
        hp = GetDamage(4);
    }
    
=======
>>>>>>> lia-branch-merged-may
}
