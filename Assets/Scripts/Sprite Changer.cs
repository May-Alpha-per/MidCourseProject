using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour

{
[SerializeField] public Image[] HeartSprites;
[SerializeField] public Sprite FullHeart;
[SerializeField] public Sprite EmptyHeart;

    public void setHp (int HP)
    {
        for (int i = 0; i < HeartSprites.Length;i++)
        {
            if (i < HP)
            {
            HeartSprites[i].sprite = FullHeart;
            }
            else
            {
            HeartSprites[i].sprite = EmptyHeart;
            } 

        }
    }

}




