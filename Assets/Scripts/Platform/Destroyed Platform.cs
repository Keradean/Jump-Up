using UnityEngine;

public class DestroyedPlatform : MonoBehaviour
{
    public Rigidbody2D rb2D; 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            if (collision.collider.GetComponent<Rigidbody2D>())
            {
                Destroy(this.gameObject);
            }
        }

    }
}
