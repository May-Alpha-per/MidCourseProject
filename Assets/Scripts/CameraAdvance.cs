using UnityEngine;

public class CameraAdvance : MonoBehaviour
{
    // לאיזה כיוון המצלמה מתקדמת בכל פגיעה: (0,1)=למעלה, (0,-1)=למטה, (1,0)=ימינה, (-1,0)=שמאלה
    public Vector2 direction = new Vector2(0f, 1f);
    public float step = 1.5f;   // כמה המצלמה מתקדמת בכל פגיעה (בערך גובה לבנה אחת)
    public float smooth = 3f;   // מהירות התנועה החלקה

    static CameraAdvance instance;
    Vector3 targetPos;

    void Awake()
    {
        instance = this;
        targetPos = transform.position;
    }

    // נקרא בכל פעם שלבנה נעלמת: המצלמה מתקדמת צעד אחד בכיוון שהוגדר
    public static void Advance()
    {
        if (instance == null)
            return;

        Vector2 dir = instance.direction.normalized;
        instance.targetPos += new Vector3(dir.x, dir.y, 0f) * instance.step;
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos, smooth * Time.deltaTime);
    }
}
