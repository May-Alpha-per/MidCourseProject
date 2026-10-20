using Unity.VisualScripting;
using UnityEngine;

public class Saint : Player
{
int HP = 3;
    
    void Start()
    {
        spriteChanger.setHp(HP);
    }
    
}
