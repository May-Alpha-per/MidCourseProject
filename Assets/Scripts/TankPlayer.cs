using UnityEngine;

public class Tank : Player
{
int HP = 5;

    void Start()
    {
        spriteChanger.setHp(HP);
    }

    //TODO - add special ability function. Has to do with available stamina.
    public override void SpecialAbility()
    {
        Debug.Log("Crushing!");
    }


    
}
