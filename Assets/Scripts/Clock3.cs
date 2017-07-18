using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Clock3 : MonoBehaviour {

    public Text timerText;
    private float secondsCount;
    private int minuteCount;
    private int hourCount = 21;

    void Update()
    {
        UpdateTimerUI();
    }


    void newDay()
    {
        SceneManager.LoadScene("Lose");
    }


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
        else if (hourCount >= 24)
        {
            hourCount = 0;
        }
        else if (hourCount >= 7 && hourCount < 21)
        {
            newDay();
        }
    }
    

}