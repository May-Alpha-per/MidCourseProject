using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float horizontalMove;
    [SerializeField] float verticalMove;

    public Animator animator;

    private Rigidbody2D rb;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");

        verticalMove = Input.GetAxis("Vertical");

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove) + Mathf.Abs(verticalMove));

        //transform.Translate(horizontalMove, verticalMove, 0);

       // transform.Translate(
         //   horizontalMove * moveSpeed * Time.deltaTime, 
         //   verticalMove * moveSpeed * Time.deltaTime, 
         //   0
       // );

        

     if (horizontalMove > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else if (horizontalMove < 0)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalMove * moveSpeed, verticalMove * moveSpeed);
    
    }
}
