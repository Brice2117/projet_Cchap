using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool finnished = false;

    // Start is called before the first frame update
    void Start()
    {
        timerText.color = Color.green;
        startTime = Time.time; 
    }

    // Update is called once per frame

    void Update()
    {
        if (finnished)//to finish time
            return;
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");//f0== 0 decimal floats
        timerText.text = "Timer : "+minutes + ":" + seconds;
    }
    public void Finnish()
    {
        timerText.color = Color.red;
        finnished = true;

    }
}
