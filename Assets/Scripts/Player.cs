using Unity.VisualScripting;
using UnityEngine;
<<<<<<< HEAD
=======
using UnityEngine.Events;
>>>>>>> lia-branch-merged-may

public abstract class Player : MonoBehaviour
{
    public int hp;
    public int maxHP;
    public int stamina;
    public int MaxStamina;
    public int damage;
    public int speed;
<<<<<<< HEAD
    public int baseSpeed; // TODO - ASK if need to use both speed & baseSpeed


=======
    public int Hit = 0;
    public SpriteChanger spriteChanger;
    public CanvasManager canvasManager;
>>>>>>> lia-branch-merged-may
//TODO - add attack function
    public virtual void Attack()
    {
        Debug.Log("Attack!");
    }

//TODO - add diying function
    public virtual void Die()
    {
<<<<<<< HEAD
        Debug.Log("I'm dead!");
=======
        canvasManager.setDeathText();
>>>>>>> lia-branch-merged-may
    }

//TODO - add getting damage function
    public virtual int GetDamage(int hit)
    {
<<<<<<< HEAD
        Debug.Log("I've been hit!");
        int updatetHP = this.hp - hit;
        Debug.Log($"my current HP is: {updatetHP}");
        if (updatetHP <= 0)
        {
            Die();
        }
        return updatetHP;
    }

=======
        Debug.Log("I've been hit!"); // after health going down, call the update method to UI 
        int updatedHP = this.hp - hit;
        Debug.Log($"my current HP is: {updatedHP}");
        spriteChanger.setHp(updatedHP);
        if (updatedHP <= 0)
        {
            Die();
        }
        else 
        {
            this.hp = updatedHP;
        }
        return updatedHP;
    }
    public virtual void GetHit()
    {
        GetDamage(1);
        Hit = Hit +1;
        Debug.Log("Hit has activated");
    }
>>>>>>> lia-branch-merged-may
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

<<<<<<< HEAD
    // void Start()
    // {
    //     hp = GetDamage(4);
    // }
=======
     void Start()
     {
        spriteChanger.setHp(hp);
     }
>>>>>>> lia-branch-merged-may
    
}
