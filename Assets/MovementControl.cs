using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    [SerializeField] Rigidbody myRB;
    [SerializeField] float velocity;
    float horizontalInput;
    float verticalInput;


    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        myRB.velocity = new Vector3(horizontalInput * velocity, 0, verticalInput * velocity);
       
    }
}
