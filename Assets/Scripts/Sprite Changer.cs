using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour

{
[SerializeField] public Image[] HeartSprites;
[SerializeField] public Sprite FullHeart;
[SerializeField] public Sprite EmptyHeart;

<<<<<<< HEAD

private int lastKnownHp = -1;

    public void setHp (int hp)
=======
    public void setHp (int HP)
>>>>>>> origin/main
    {

        if (hp == lastKnownHp) return; 

        lastKnownHp = hp;

        for (int i = 0; i < HeartSprites.Length;i++)
        {
<<<<<<< HEAD
            
            if (i < hp)
            {
            //Debug.Log($"Setting heart {i} to full");
=======
            if (i < HP)
            {
>>>>>>> origin/main
            HeartSprites[i].sprite = FullHeart;
            }
            else
            {
<<<<<<< HEAD
            //Debug.Log($"Setting heart {i} to empty");
=======
>>>>>>> origin/main
            HeartSprites[i].sprite = EmptyHeart;
            } 

        }
    }

}




