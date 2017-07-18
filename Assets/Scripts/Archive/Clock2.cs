using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock2 : MonoBehaviour {

    public Text timerText;
    private float secondsCount;
    private int minuteCount;
    private int hourCount = 23;

    void Update()
    {
        UpdateTimerUI();
    }

    //call this on update
    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        //timerText.text = hourCount + "h:" + minuteCount + "m:" + (int)secondsCount + "s";
        //timerText.text = hourCount + ":" + minuteCount;
        timerText.text = hourCount.ToString("D2") + ":" + minuteCount.ToString("D2"); 
        if (secondsCount >= 1)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }
}
