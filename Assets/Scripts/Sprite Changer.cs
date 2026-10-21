using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour

{
[SerializeField] public Image[] HeartSprites;
[SerializeField] public Sprite FullHeart;
[SerializeField] public Sprite EmptyHeart;


private int lastKnownHp = -1;

    public void setHp (int HP)
    {

        if (HP == lastKnownHp) return; 

        lastKnownHp = HP;

        for (int i = 0; i < HeartSprites.Length;i++)
        {
            
            if (i < HP)
            {
            //Debug.Log($"Setting heart {i} to full");
            HeartSprites[i].sprite = FullHeart;
            }
            else
            {
            //Debug.Log($"Setting heart {i} to empty");
            HeartSprites[i].sprite = EmptyHeart;
            } 

        }
    }

}




