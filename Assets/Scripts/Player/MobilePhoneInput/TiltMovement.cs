using UnityEngine;

public class TiltMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed; 

    // Update is called once per frame
    void Update()
    {
        float tilt = Input.acceleration.x;

        Vector3 movement = new Vector3(tilt * moveSpeed, 0f, 0f);

        transform.Translate(movement * Time.deltaTime); 
    }
}
