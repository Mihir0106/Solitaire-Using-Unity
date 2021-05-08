using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    public Text timerText;
    float timer, seconds, minutes;
    public bool Fstep;
    float Smaintainer;
   
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        Fstep = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveCount.instance.count >= 1)
            Fstep = true;
        if (Fstep)
        {
            timer += Time.deltaTime;
            Smaintainer += Time.deltaTime;
            seconds = (int)timer % 60;
            minutes = (int)timer / 60;
        }
        timerText.text = "Time: " + minutes.ToString("00") + ":" + seconds.ToString("00");

        if (Smaintainer >= 10)
        {
            Smaintainer = 0;
            SCoreManager.instance.score -= 10;
        }
    }

    public void Resets()
    {
        timer = 0;
        seconds = 0;
        minutes = 0;
        Fstep = false;
    }
}


