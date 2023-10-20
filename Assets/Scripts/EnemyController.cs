using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 15.0f;
    //private float turnSpeed = 40.0f;
    //private float horizontalInput;
    //private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this is where we get player input
        //horizontalInput = Input.GetAxis("Horizontal");
        //forwardInput = Input.GetAxis("Vertical");
       
        // moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Rotates the car based on horizontal input
       // transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
