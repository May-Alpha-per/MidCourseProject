using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
[SerializeField] private Sprite[] HeartSprites;
private Sprite newSprite;

    public void GetHit() // change from collision to on hit change heart to empty? 
    // and change heart data to empty heart so the text can appear on the screen
    {
        newSprite = HeartSprites[Random.Range(0, HeartSprites.Length)];
        gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
        
    }
}
