using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charictercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 movementVector = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform; 
        
    }

    private void Update() {
        MoveCharacter();
        KeepChatacterOnXAxis();
    }

    private void MoveCharacter() {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector *= (moveSpeed * Time.deltaTime);
        controller.Move(movementVector);
    }

    private void KeepChatacterOnXAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
    
   
}
