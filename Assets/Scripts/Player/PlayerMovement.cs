using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Handles player movement with horizontal controls and screen wrapping.
/// Player can move left/right and wraps around screen boundaries.
/// Game ends when player falls below a certain Y threshold.
/// </summary>

[RequireComponent(typeof(Rigidbody2D))] // 
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float leftLimit;
    [SerializeField] private float rightLimit;

    private Rigidbody2D rb2D;
    private Vector2 moveInput;
    private GameManager gameManager; 

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>(); 
    }

    /// <summary>
    /// Cheating...
    /// </summary>
    /*
    public void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            rb2D.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
        }
    }
    */

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        gameManager = FindAnyObjectByType<GameManager>();

        if (gameManager = null) return; 
    }

    // <summary>
    /// Handle physics-based movement in FixedUpdate for consistent frame rate.
    /// Applies horizontal movement based on input while preserving vertical velocity.
    /// </summary>
    void FixedUpdate()
    {
        Vector2 velocity = rb2D.linearVelocity;
        velocity.x = moveInput.x * movementSpeed; 
        rb2D.linearVelocity = velocity;
    }

    /// <summary>
    /// Handle screen wrapping and game over conditions after all other updates.
    /// </summary>
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

        if (rb2D.position.y < -1f)
        {
            FindAnyObjectByType<GameManager>().GameOver();

            gameManager?.GameOver(); 
        }
    }
}
