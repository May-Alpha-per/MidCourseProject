using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void Awake()
    {
        // כדי שהשחקן יזהה התנגשויות צריך Rigidbody2D ו-Collider2D - מוסיפים אוטומטית אם חסרים
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb == null)
            rb = gameObject.AddComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.gravityScale = 0f;
        rb.freezeRotation = true;

        if (GetComponent<Collider2D>() == null)
            gameObject.AddComponent<CapsuleCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Wall wall = col.gameObject.GetComponent<Wall>();
        if (wall)
            wall.OnHit();
    }
}
