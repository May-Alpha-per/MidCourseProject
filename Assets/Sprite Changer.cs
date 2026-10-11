using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
[SerializeField] private Image[] HeartSprites;
[SerializeField] private Sprite FullHeart;
[SerializeField] private Sprite EmptyHeart;
private Sprite newSprite;    
    public void setHp (int Playerhp)
    {
        for (int i = 0; i < HeartSprites.Length; i++)
        {
            if (i < Playerhp)
            {
                newSprite = FullHeart; 
            }
            else
            {
                newSprite = EmptyHeart; 
            }
            HeartSprites[i].sprite = newSprite;
        }
    
    }
}

 
    
