using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float horizontalMove;
    [SerializeField] float verticalMove;

    public Animator animator;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");

        verticalMove = Input.GetAxis("Vertical");

        transform.Translate(horizontalMove, verticalMove, 0);
    }
}
