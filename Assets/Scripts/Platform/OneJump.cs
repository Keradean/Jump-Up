using UnityEngine;

public class OneJumop : MonoBehaviour
{
    [SerializeField] private float jumpForce;

    private Rigidbody rb2D;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
           if (rb2D != null)
           {
                Vector2 velocity = rb2D.linearVelocity;
                velocity.y = jumpForce;
                rb2D.linearVelocity = velocity;
           }
           if (collision.collider)
           {
                Destroy(this.gameObject);
           }
        }

    }
}
