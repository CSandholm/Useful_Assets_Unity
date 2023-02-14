using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public Text timerText;
    private float seconds;
    private int minutes;

    void Update()
    {
        updateTimer();
    }
    public void updateTimer()
    {
        seconds += Time.deltaTime;
        timerText.text = minutes.ToString("00")+":"+seconds.ToString("00");
        if(seconds>=60)
        {
            minutes++;
            seconds=0;
        }
        else if(minutes>=60)
        {
            minutes=0;
        }

    }
}
