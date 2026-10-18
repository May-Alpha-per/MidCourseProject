using UnityEngine;

public class Boulder : Enemy
{


//TODO - add diying function
    public override void Die()
    {
        Debug.Log("I'm dead!");
    }

//TODO - add getting damage function
    public override int GetDamage(int hit)
    {
        Debug.Log("I've been hit!");
        int updatetHP = this.HP - hit;
        Debug.Log($"my current HP is: {updatetHP}");
        return updatetHP;
    }


    // void Start()
    // {
    //     hp = GetDamage(4);
    // }
    
}
