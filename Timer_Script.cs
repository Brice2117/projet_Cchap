using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_Script : MonoBehaviour
{
    //Text intance enabling the count;
    public Text timerText;
    //Value of time at the beginning of the count;
    private float startTime;


    /**
     * Start is called before the first frame update;
     */
    void Start()
    {
        //Initializing of the first date of the time;
        startTime = Time.time;
    }

    /**
     * Update is called once per frame;
     * On each frame with take the time and we make the calculation of the time spent;
     */
    void Update()
    {
        //Taking of current time;
        float t = Time.time - startTime;

        //Conversion in seconds and minutes with 2 numbers before the coma;
        string minutes = ((int)t / 60).ToString("D2");
        string seconds = ((int)t % 60).ToString("D2");

        //Printing of the time value obtained;
        timerText.text = minutes + " : " + seconds;
    }
}
