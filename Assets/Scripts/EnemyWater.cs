using UnityEngine;

public class EnemyWater : MonoBehaviour
{  
    [SerializeField] private int damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            collision.GetComponent<Fighter>().TakePlayerDamage(damage);
    }


    // Update is called once per frame
    void Update()
    {

    }
}

