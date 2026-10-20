using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float horizontalMove;
    [SerializeField] float verticalMove;
    [SerializeField] float speed = 3f; // יחידות בשנייה - להקטין כדי להאט

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        transform.Translate(horizontalMove * speed * Time.deltaTime, verticalMove * speed * Time.deltaTime, 0);
    }
}
