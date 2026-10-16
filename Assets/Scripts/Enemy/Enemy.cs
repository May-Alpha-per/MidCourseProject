using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int hp;
    public int maxHP;
    // public int stamina;
    // public int MaxStamina;
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
        Debug.Log("I've been hit!");
        int updatetHP = this.hp - hit;
        Debug.Log($"my current HP is: {updatetHP}");
        if (updatetHP <= 0)
        {
            Die();
        }
        return updatetHP;
    }

    public virtual void Move()
    {
        Debug.Log("I'm moving, I'm moving!");
    }


    // void Start()
    // {
    //     hp = GetDamage(4);
    // }
    
}
