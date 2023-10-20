using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
   public void OnButtonPress(string buttonValue)
   {
        switch(buttonValue)
        {
            case "Plane":
            {   
                SceneManager.LoadScene("Challenge 1");
                break;
            }

            case "Truck":
            {   
                SceneManager.LoadScene("Prototype 1");
                break;
            }
            case "Exit":
            {
                Application.Quit();
                break;
            }
           
            default:
            {
                break;
            }
        }
   }
}
