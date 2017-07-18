using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour {

    double lastChange = 1.0;

    int hour = 9;
    int minutes = 0;
    string ampm = "pm";

    void Update()
    {
        if (Time.time - lastChange > 1.0)
        {
            minutes++;
            if (minutes == 6)
            {
                minutes = 0;
                hour++;
                if (hour == 12)
                {
                    if (ampm == "pm")
                    {
                        ampm = "am";
                    }
                    else
                    {
                        newDay();
                    }
                }
                if (hour == 13)
                {
                    hour = 1;
                }
            }
            lastChange = Time.time;
        }
    }

    void OnGUI()
    {
        GUILayout.Label(hour.ToString() + ":" + minutes.ToString() + "0" + ampm);
    }

    void newDay()
    {
        SceneManager.LoadScene("Lose");
    }
}