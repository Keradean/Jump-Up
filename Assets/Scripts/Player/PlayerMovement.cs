using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movement; 
    [SerializeField] private float movementSpeed; 


    private Rigidbody2D rb2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb2D.linearVelocity;
        velocity.x = movement;
        rb2D.linearVelocity = velocity;
    }
}
