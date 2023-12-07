using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public GameObject Cam1;

    public GameObject Cam2;

    private bool a = false;
    private bool b = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cam1.SetActive(a);
        Cam2.SetActive(b);
        if (Input.GetKeyDown(KeyCode.P))
        {
            b = !b;
            a = !a;
        }
    }
}
