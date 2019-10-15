using UnityEngine;

public class RobotController : MonoBehaviour
{
    // Stores a reference of the Rigidbody2D component (if any)
    Rigidbody2D _rigidbody;

    // Stores a reference of the SpriteRenderer component (if any)
    SpriteRenderer _renderer;

    // A modifier for the movement
    public float speedMultiplier = 10;

    // A modifier for the speed
    public float jumpMultiplier = 10;

    // Start is called before the first frame update
    private void Start()
    {
        // Retrieves the rigidbody component
        _rigidbody = GetComponent<Rigidbody2D>();
        
        // Retrieves the sprite renderer component
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Gets the horizontal thumbstick axis (-1:+1) and stores the
        // value in a variable
        float hMove = Input.GetAxis("Horizontal");

        // Store in a variable the movement (horizontal) force
        Vector2 moveForce = Vector2.right * hMove * speedMultiplier;
        
        // Adds the evaluated force to the rigidbody
        _rigidbody.AddForce(moveForce);

        // If the jump button has been pressed this frame...
        if(Input.GetButtonDown("Jump"))
        {
            // Store in a variable the jump (vertical) force
            Vector2 jumpForce = Vector2.up * jumpMultiplier;

            // Adds the evaluated force to the rigidbody
            _rigidbody.AddForce(jumpForce, ForceMode2D.Impulse);
        }

        // Flips the sprite depending on the thumbstick axis
        if(hMove > 0)
        {
            _renderer.flipX = false;
        } else if (hMove < 0)
        {
            _renderer.flipX = true;
        }
    }
}
