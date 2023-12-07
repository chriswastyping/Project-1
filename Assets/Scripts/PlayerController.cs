 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float horsePower = 0;
    [SerializeField] float speed = 15.0f;
    private const float turnSpeed = 40.0f;
    private float horizontalInput;
    private float forwardInput;

    private Rigidbody playerRb;

    [SerializeField] GameObject centreOfMass;

    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] float rpm;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();    
        playerRb.centerOfMass = centreOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // this is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
       
        // moves the car forward based on vertical input
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);

        speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 2.237f); // For KPH CHANGE 2.237 TO 3.6
        speedometerText.SetText("Speed: " + speed + "mph");
        rpm = Mathf.Round((speed % 30) * 40);
        rpmText.SetText("RPM: " + rpm);
    }
}
