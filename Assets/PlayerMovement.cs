using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 300f;
    
    public LayerMask groundMask;

    public float jumpForce = 7f;

    public CapsuleCollider collider;

    public Rigidbody rb;

    //Slope
    public float slopeForce;

    public float slopeForceRayLength;

    void Update()
    {
        // Movement
        Vector2 xMov = new Vector2(Input.GetAxisRaw("Horizontal") * transform.right.x, Input.GetAxisRaw("Horizontal") * transform.right.z);
        Vector2 zMov = new Vector2(Input.GetAxisRaw("Vertical") * transform.forward.x, Input.GetAxisRaw("Vertical") * transform.forward.z);

        Vector2 velocity = (xMov + zMov).normalized * speed * Time.deltaTime;

        rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.y);

        if (isGrounded() && Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (OnSlope()) 
        {
            rb.AddForce(Vector3.down * collider.height / 2 * slopeForce * Time.deltaTime);
        }
    }

    private bool isGrounded() 
    {
        return Physics.CheckCapsule(collider.bounds.center, new Vector3(collider.bounds.center.x, collider.bounds.min.y, collider.bounds.center.z), collider.radius * .10f, groundMask);
    }

    private bool OnSlope() 
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, collider.height / 2 * slopeForceRayLength)) 
        {
            if (hit.normal != Vector3.up) 
            {
                return true;
            }
        }

        return false;
    }

   
}
