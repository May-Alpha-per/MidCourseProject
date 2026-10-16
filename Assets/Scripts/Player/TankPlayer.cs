using UnityEngine;

public class Tank : Player
{
int HP = 5;
//TODO - add attack function
    public override void Attack()
    {
        Debug.Log("Attack like a TANK!");
    }

//TODO - add dying function
    public override void Die()
    {
        base.Die();
        Debug.Log("I'm dead like a troll!");
    }

    void Start()
    {
        spriteChanger.setHp(HP);
    }

    // //TODO - add getting damage function
    //     public virtual int GetDamage(int hit)
    //     {
    //         Debug.Log("I've been hit!");
    //         int updatetHP = this.hp - hit;
    //         Debug.Log($"my current HP is: {updatetHP}");
    //         return updatetHP;
    //     }

    // TODO - enable item pickup. Could be temp effect (speed / hp / stamina),
    // or could be permenant effect (sword / wings / spiky armor)
    // public virtual void PickUpItem()
    // {
    //     Debug.Log("Got a cool new item!");
    // }

    //TODO - add special ability function. Has to do with available stamina.
    public override void SpecialAbility()
    {
        Debug.Log("Crushing!");
    }


    
}
