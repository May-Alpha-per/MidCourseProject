using UnityEngine;

public class Wall : MonoBehaviour
{
    // סדר הלבנים שיורדות, אחת בכל פגיעה (השמות כמו ב-Hierarchy)
    static readonly string[] bricks = { "wall_first", "wall_second", "wall_third", "wall_fourth" };

    void Awake()
    {
        // אם אין ללבנה קוליידר - מוסיפים אחד אוטומטית (הגודל מותאם לספרייט)
        if (GetComponent<Collider2D>() == null)
            gameObject.AddComponent<BoxCollider2D>();
    }

    public void OnHit()
    {
        RemoveNextBrick();
    }

    void RemoveNextBrick()
    {
        foreach (string brickName in bricks)
        {
            GameObject brick = GameObject.Find(brickName);
            if (brick != null)
            {
                Debug.Log("Removing " + brickName);
                brick.SetActive(false); // כדי שהפגיעה הבאה לא תמצא אותה שוב
                Destroy(brick);
                return;                 // רק לבנה אחת בכל פגיעה
            }
        }
    }
}
