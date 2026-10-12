using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour

{
[SerializeField] public Image[] HeartSprites;
[SerializeField] public Sprite FullHeart;
[SerializeField] public Sprite EmptyHeart;
public Player player;

    public void setHp (int hp)
    {
        player.hp = hp;
        for (int i = 0; i < HeartSprites.Length;i++)
        {
            if (i < hp)
            {
                Debug.Log($"Setting heart {i} to full");
                HeartSprites[i].sprite = FullHeart;
            }

        }
    }
        void Start()
    {
        player = FindAnyObjectByType<Fighter>();
        setHp(player.hp);
        Debug.Log(player.Hit);
while (player.Hit >= 1)
        {
            Debug.Log($"Setting heart {player.hp - player.Hit} to full");
            HeartSprites[player.hp - player.Hit].sprite = FullHeart; 

        }
    }
}





