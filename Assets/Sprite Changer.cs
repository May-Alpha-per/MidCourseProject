using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
[SerializeField] private Sprite[] sprites;
[SerializeField] private Sprite newSprite;

    void OnCollisionEnter2D(Collision2D collision) // change from collision to on hit change heart to empty? 
    // and change heart data to empty heart so the text can appear on the screen
    {
        newSprite = sprites[Random.Range(0, sprites.Length)];
        gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;

        
    }

}
