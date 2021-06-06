using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 700f;
    public float sideForce = 50f;

    void FixedUpdate()
    {
        // Adding force to the box every frame
        // Time.deltaTime multiplication is to correct it and ake it the same for any frame rate
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if( Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(-sideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);  
        }
        if( Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(sideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);  
        }
        if( Input.GetKey(KeyCode.DownArrow)) {
            rb.AddForce(0,0,-100 * Time.deltaTime);  
        }
        
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndLife();
        }


    }
}
