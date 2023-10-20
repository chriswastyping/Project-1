using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerSpin : MonoBehaviour
{
    private float spinSpeed = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, spinSpeed * Time.deltaTime, Space.Self);
    }
}
