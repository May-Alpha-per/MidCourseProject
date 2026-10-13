using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour

{
[SerializeField] public Image[] HeartSprites;
[SerializeField] public Sprite FullHeart;
[SerializeField] public Sprite EmptyHeart;

    public void setHp (int hp)
    {
        for (int i = 0; i < HeartSprites.Length;i++)
        {
            if (i < hp)
            {
            Debug.Log($"Setting heart {i} to full");
            HeartSprites[i].sprite = FullHeart;
            }
            else
            {
            Debug.Log($"Setting heart {i} to empty");
            HeartSprites[i].sprite = EmptyHeart;
            } 

        }
    }

}




