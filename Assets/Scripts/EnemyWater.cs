using UnityEngine;

public class EnemyWater : MonoBehaviour
{

    [SerializeField] private float damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            collision.GetComponent<HP>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

