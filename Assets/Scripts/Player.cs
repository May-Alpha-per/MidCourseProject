using UnityEngine;

public abstract class Player : MonoBehaviour
{
    public int hp;
    public int maxHP;
    public int stamina;
    public int MaxStamina;
    public int damage;
    public int speed;
    public int baseSpeed;


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
        Debug.Log("I've been hit!");
        int updatetHP = this.hp - hit;
        Debug.Log($"my current HP is: {updatetHP}");
        return updatetHP;
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
