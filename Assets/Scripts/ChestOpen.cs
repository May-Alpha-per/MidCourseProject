using UnityEngine;

public class ChestOpen : MonoBehaviour

{
    public SpriteChanger spritechanger;
    public Player Tank;
    public Player Fighter;
    public Player Saint;

    static readonly string[] Chests = { "Chest", "Chest", "Chest", "Chest" };


        public void OnHit()
    {
        OpenChest();
    }
   public void OpenChest()
    {
    foreach (string ChestNames in Chests)
{
        if (ChestNames != null)
{
            GameObject Chest = GameObject.Find(ChestNames);
            CameraAdvance.Advance(); // המצלמה מתקדמת צעד
            Destroy(Chest);
            return;                 // רק לבנה אחת בכל פגיעה
    }
}
}
}

