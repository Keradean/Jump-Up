using UnityEngine;

public class DeadZone : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(other.gameObject);
        }  
}
