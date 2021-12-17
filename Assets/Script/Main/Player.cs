using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigidbody;

   
    private float gravity = 10.0f, maxVelocityChange = 50f, jumpHeight = 1f;

    public float speed;

    void Start()
    {       
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
        rigidbody.useGravity = false;
    }

    private void FixedUpdate()
    {
        if(Layout_Main.DIRCTION.magnitude != 1)
        {
            Vector3 position = new Vector3(Layout_Main.DIRCTION.x * speed, 0,
                Layout_Main.DIRCTION.y * speed);

            position = transform.TransformDirection(position);

            Vector3 velocity = rigidbody.velocity;
            Vector3 velocityChange = (position - velocity);

            velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
            velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
            velocityChange.y = 0;
            rigidbody.AddForce(velocityChange, ForceMode.VelocityChange);

            if (Layout_Main.JUMP_SW)
                rigidbody.velocity = new Vector3(velocity.x, CalculateJumpVerticalSpeed(), velocity.z);
        }

        rigidbody.AddForce(new Vector3(0, -gravity * rigidbody.mass, 0));
    }

    // Jump
    float CalculateJumpVerticalSpeed()
    {
        return Mathf.Sqrt(2 * jumpHeight * gravity);
    }
}
