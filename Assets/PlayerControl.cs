using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] Rigidbody myRB;
    [SerializeField] float speed;
    [SerializeField] List<NodeControl> nodeControls;
    [SerializeField] int currentposition = 0;
    NodeControl currentNodo;
    float currenttime;
    Vector3 velocity;

    private void Start()
    {
        
        myRB = GetComponent<Rigidbody>();
        currentNodo = nodeControls[currentposition];
        currenttime = currentNodo.GetTime();
        velocity = (currentNodo.transform.position - transform.position) / currenttime;
    }
    private void FixedUpdate()
    {
        myRB.velocity = velocity;
    }



   

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Point")
        {
            if(currentposition == nodeControls.Count-1)
            {
                currentposition = 0;
                currentNodo = nodeControls[currentposition];
                currenttime = currentNodo.GetTime();
            }
            else
            {
                currentposition++;
                currentNodo = nodeControls[currentposition];
                currenttime = currentNodo.GetTime();
            }
             velocity = (currentNodo.transform.position - transform.position) / currenttime;
        }
    }
}
