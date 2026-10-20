using Unity.VisualScripting;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
    public  int HP;
    public int maxHP;
    public int stamina;
    public int MaxStamina;
    public int damage;
    public int speed;
    public int Hit = 0;
    public SpriteChanger spriteChanger;
    public CanvasManager canvasManager;
    public Animator animator;
    protected string className;

    protected const string FlashRedAnim = "FlashRed";

    void Awake()
    {
        className = GetType().Name;
    }
    
//TODO - add attack function
    public virtual void Attack()
    {
        Debug.Log("Attack!");
    }

    
    public void TakePlayerDamage(int damage)
    {
        HP -= damage;
        Debug.Log("Player got hit! Current HP: " + HP);

        if (spriteChanger != null)
        {
            spriteChanger.setHp(HP);
        }

        if (HP <= 0)
        {
            Die();
        }

        else
        {
            animator.SetTrigger(FlashRedAnim);
            animator.SetTrigger($"{className}_block");
        }
    }


//TODO - add diying function
    public virtual void Die()
    {
        Debug.Log("I'm dead T-T");

        animator.SetTrigger($"{className}_die");
        
        //GetComponent<Collider2D>().enabled = false;
        GetComponent<Rigidbody2D>().simulated = false;

        GetComponent<PlayerMovement>().enabled = false;

        this.enabled = false; 

        canvasManager.setDeathText();        
    }

    void OnEnable()
    {
        spriteChanger.setHp(HP);
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

     void Start()
     {
        spriteChanger.setHp(HP);
     }
    
}
