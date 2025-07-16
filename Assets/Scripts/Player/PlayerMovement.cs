using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float leftLimit;
    [SerializeField] private float rightLimit;

    private Rigidbody2D rb2D;
    private Vector2 moveInput;

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>(); 
    }

    
    public void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            rb2D.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
        }
    }

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb2D.linearVelocity;
        velocity.x = moveInput.x * movementSpeed; 
        rb2D.linearVelocity = velocity;
    }

    void LateUpdate()
    {
        if (transform.position.x < leftLimit)
        {
            transform.position = new Vector3(rightLimit, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > rightLimit)
        {
            transform.position = new Vector3(leftLimit, transform.position.y, transform.position.z);
        }
    }
}
