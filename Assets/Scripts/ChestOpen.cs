using UnityEngine;

public class ChestOpen : MonoBehaviour

{
    public SpriteChanger spritechanger;
    public Player Tank;
    public Player Fighter;
    public Player Saint;


    public void OnHit()
    {
        OpenChest();
    }
    
    void OpenChest()
    {
            GameObject Chest = GameObject.Find("Chest");
            if (Chest != null)
            {
                CameraAdvance.Advance(); // המצלמה מתקדמת צעד
                Chest.SetActive(false); // כדי שהפגיעה הבאה לא תמצא אותה שוב
                Destroy(Chest);
                return;                 // רק לבנה אחת בכל פגיעה
            }
    }
}
