using UnityEngine;

public class Skeleton : Enemy
{

//TODO - add attack function
    public override void Attack()
    {
        Debug.Log("Attack!");
    }

//TODO - add diying function


    public override void Move()
    {
        Debug.Log("I'm moving, I'm moving!");
    }


    // void Start()
    // {
    //     hp = GetDamage(4);
    // }
    
}
