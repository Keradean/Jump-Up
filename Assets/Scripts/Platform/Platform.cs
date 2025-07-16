using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    public Rigidbody2D rb2D; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            collision.collider.GetComponent<Rigidbody2D>();
            if (rb2D != null)
            {
                Vector2 velocity = rb2D.linearVelocity;
                velocity.y = jumpForce;
                rb2D.linearVelocity = velocity;
            }
        }
        
    }
}
