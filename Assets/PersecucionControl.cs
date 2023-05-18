using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersecucionControl : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Rigidbody myRB;
    [SerializeField] float time;
    Vector3 velocidad;

    private void Start()
    {
        velocidad = (target.position - transform.position) / time;
        myRB.velocity = velocidad;
    }

    private void Update()
    {
        if(time > 0)
        {
            time = time - Time.deltaTime;
        }
        Vector3 nuevavelocidad = (target.position - transform.position) / (time);
        myRB.velocity += (2*nuevavelocidad)  * Time.deltaTime;
        Debug.Log(time);
 
    }
}
