using Unity.VisualScripting;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
    public  int Playerhp;
    public int maxHP;
    public int stamina;
    public int MaxStamina;
    public int damage;
    public int speed;

//TODO - add attack function
    public virtual void Attack()
    {
        Debug.Log("Attack!");
    }

//TODO - add diying function
    public virtual void Die()
    {
        Debug.Log("I'm dead!");
    }

//TODO - add getting damage function
    public virtual int GetDamage(int hit)
    {
        Debug.Log("I've been hit!"); // after health going down, call the update method to UI 
        int updatedHP = this.Playerhp - hit;
        Debug.Log($"my current HP is: {updatedHP}");
        if (updatedHP <= 0)
        {
            Die();
        }
        return updatedHP;
    }
    public virtual void GetHit()
    {
        GetDamage(1);
        
    }
    public virtual void Move()
    {
        Debug.Log("I'm moving, I'm moving!");
    }
    
// TODO - enable item pickup. Could be temp effect (speed / hp / stamina),
// or could be permenant effect (sword / wings / spiky armor)
    public virtual void PickUpItem()
    {
        Debug.Log("Got a cool new item!");
    }

//TODO - add special ability function. Has to do with available stamina.
    public virtual void SpecialAbility()
    {
        Debug.Log("I'm speciallllll");
    }

    // void Start()
    // {
    //     hp = GetDamage(4);
    // }
    
}
