using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject secondHand;
    public GameObject minuteHand;
    public GameObject hourHand;

    string oldSeconds;


    // Update is called once per frame
    void Update()
    {
        string seconds = System.DateTime.UtcNow.ToString("ss");

        if(seconds != oldSeconds)
        {
            UpdateTimer();
            
        }
        oldSeconds = seconds;
    }

    void UpdateTimer()
    {
        int secondInt = int.Parse(System.DateTime.UtcNow.ToString("ss"));
        int minuteInt = int.Parse(System.DateTime.UtcNow.ToString("mm"));
        int hourInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));

        float secondHandRotation = (secondInt * 6);
        secondHand.transform.localEulerAngles = new Vector3(secondHandRotation, 0, 0);
        float minuteHandRotation = (minuteInt * 6);
        minuteHand.transform.localEulerAngles = new Vector3(minuteHandRotation, 0, 0);
        float hourHandRotation = (hourInt * 30);
        hourHand.transform.localEulerAngles = new Vector3(hourHandRotation, 0, 0);
    }
}
