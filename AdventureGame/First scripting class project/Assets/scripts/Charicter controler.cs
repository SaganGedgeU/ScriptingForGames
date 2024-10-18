using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charictercontroler : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f ;

    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;
   /*nessisary*/ private Vector3 movementVector = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;

    }

    private void Update()
    {
        MoveCharacter();
       // ApplyGravity();
        KeepChatacterOnXAxis();
    }

    private void MoveCharacter()
    {
         var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput,0,0)*(moveSpeed *Time.deltaTime);  
        controller.Move(move);

       // if (Input.GetButtonDown("Jump") && controller.isGrounded)
       // { 
       //     velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
       // }
    }

    private void ApplyGravity() {
        if (!controller.isGrounded) {
            velocity.y += gravity * Time.deltaTime;
           // Debug.Log("Choben");
        }
        else {
            velocity.y = 0f;
        }

        controller.Move(velocity * Time.deltaTime);

    }

    private void KeepChatacterOnXAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }


}
