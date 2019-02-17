using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class Move_1 : MonoBehaviour
{
    public GameObject[] waypoints;  //we create an empty objects to use them as a way points
    int current = 0;                //see which way point we are using -->way point numb
    //float rotSpeed;
    public float speed;             //speed of move
    float WPradius = 1;             //way point radius        
    void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)//we check the distance from the way point
        {
            current++;
            if (current >= waypoints.Length)
                current = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}
