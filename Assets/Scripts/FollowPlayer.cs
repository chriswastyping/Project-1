using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
     public GameObject player;
    private Vector3 offset;
    // our buffer variable for storing the current setting of the camera position
    public bool offsetInput= true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
       // we take button F for switching. when it's pressed we can do a permanent shift of offsetinput to either true or false
        if (Input.GetKeyDown(KeyCode.F))
        {
            offsetInput = !offsetInput;
        }
        // check if offsetInput is true
        if (offsetInput)
        {
            // offset values for Behind the player
            offset = new Vector3(0, 5, -7);
        }
        else
        {
            //In front of the car
            offset = new Vector3(-0.39f, 2.54f, 0.44f);
        }
        // adds the offsets to the camera position 
        transform.position = player.transform.position + offset;
    }
}
