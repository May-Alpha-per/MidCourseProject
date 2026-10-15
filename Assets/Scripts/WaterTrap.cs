using UnityEngine;

public class TrapDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Hp>.TakeDamage(damage);
        }
    }

}