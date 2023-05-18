using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUV : MonoBehaviour
{
    [SerializeField] Rigidbody myRB;
    [SerializeField] Vector3 aceleration;
    [SerializeField] float time;
    [SerializeField] Vector3 velocidad;
    [SerializeField] Vector3 velocidadinicial;


    private void Start()
    {
        velocidad = ((velocidadinicial * time) + ((aceleration * Mathf.Pow(time,2))/2));
        myRB.velocity = velocidad;
    }

}
