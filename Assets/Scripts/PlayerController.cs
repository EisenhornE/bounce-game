using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] public float speed = 10f;
    [SerializeField] public float jumpForce = 8f;
    public bool isOnGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
        if (Input.GetKey(KeyCode.Space) && isOnGround)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        if (rb.velocity.x == 10)
        {
            Vector2.ClampMagnitude(rb.velocity, speed);
        }

        if (rb.velocity.x < 0)
        {
            rb.gravityScale = 2f;
        }
        else
        {
            rb.gravityScale = 1f;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Top") || collision.gameObject.name == "Platform")
        {
            isOnGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Top") || collision.gameObject.name == "Platform")
        {
            isOnGround = false;
        }
    }
}