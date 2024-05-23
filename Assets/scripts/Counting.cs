using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counting : MonoBehaviour
{
    public float TimeLeft;
    public TextMeshProUGUI TimeText;
    public bool TimerOn = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                //checks if we are counting and if we are it updates the timer by subtracting one second every second
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                //stops timer and logs that time is up
                Debug.Log("Time is up!");
                TimeLeft = 0;
                TimerOn = false;

                TimeText.text = "Time is up!";
            }
        }
    }

    //adds minutes, seconds, and updates the TimeText
    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimeText.text = minutes + ":"+ seconds;
    }

}