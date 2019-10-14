using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    // Stores a reference of the Rigidbody2D component (if any)
    Rigidbody2D _rigidbody;

    // Stores a reference of the SpriteRenderer component (if any)
    SpriteRenderer _renderer;

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
        
    }
}
