using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StopCube : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        try
        {
            GameObject.Find("TimeText").SendMessage("Finnish");
            //ameObject.Find("FPSController").SendMessage("SetYourPos");
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
