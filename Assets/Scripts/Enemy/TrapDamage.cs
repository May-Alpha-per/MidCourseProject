using UnityEngine;

public class WaterTrap : MonoBehaviour
{

    [SerializeField] private float damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            collision.GetComponent<hp>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
