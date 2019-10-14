using UnityEngine;

public class RobotController : MonoBehaviour
{
    // Stores a reference of the Rigidbody2D component (if any)
    Rigidbody2D _rigidbody;

    // Stores a reference of the SpriteRenderer component (if any)
    SpriteRenderer _renderer;

    public float speedMultiplier = 10;

    public float jumpMultiplier = 10;

    // Start is called before the first frame update
    void Start()
    {
        // Retrieves the rigidbody component
        _rigidbody = GetComponent<Rigidbody2D>();
        // Retrieves the sprite renderer component
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float hMove = Input.GetAxis("Horizontal");

        Vector2 moveForce = Vector2.right * hMove * speedMultiplier;
        _rigidbody.AddForce(moveForce);

        // Input.GetButtonDown("Jump")
        
        if(Input.GetButtonDown("Jump"))
        {
            Vector2 jumpForce = Vector2.up * jumpMultiplier;
            _rigidbody.AddForce(jumpForce, ForceMode2D.Impulse);
        }

        if(hMove > 0)
        {
            _renderer.flipX = false;
        } else if (hMove < 0)
        {
            _renderer.flipX = true;
        }
    }
}
