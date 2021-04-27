using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    CharacterController characterController;
    public float speed = 6.0f;
    private Vector3 moveDirection = Vector3.zero;

    public Transform playerBody;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerBody = transform;
    }

    // Update is called once per frame
    void Update()
    {

        // move direction directly from axes
        checkMovement();
        
    }


    void checkMovement()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= speed;

        characterController.Move(moveDirection * Time.deltaTime);
        
    }
}
