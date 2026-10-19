using UnityEngine;

public class EnemyWater : MonoBehaviour
{  

    [SerializeField] private int damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Fighter>().TakePlayerDamage(damage);
            // Submerge player
            SpriteRenderer playerSpriteRenderer = collision.GetComponent<Fighter>().GetComponent<SpriteRenderer>();
            playerSpriteRenderer.maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Reset player
            SpriteRenderer playerSpriteRenderer = collision.GetComponent<Fighter>().GetComponent<SpriteRenderer>();
            playerSpriteRenderer.maskInteraction = SpriteMaskInteraction.None;
        }
    }


    
}

