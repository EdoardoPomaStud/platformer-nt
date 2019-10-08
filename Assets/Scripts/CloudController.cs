using UnityEngine;

public class CloudController : MonoBehaviour
{

    // The speed of the cloud object
    public float speed;
    
    // Update is called once per frame
    void Update()
    {
        // Stores the direction of movement
        Vector2 direction = Vector2.right;

        // Translates the element by direction, speed and time elapsed since last frame
        transform.Translate(Time.deltaTime * direction * speed);
    }

    // When the renderer of the GameObject is no longer visible...
    void OnBecameInvisible()
    {
        // ... set its position on the left of the camera
        Vector2 resetPosition = new Vector2(-20, transform.position.y);
        transform.position = resetPosition;
    }
}
