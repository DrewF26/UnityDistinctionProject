using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counting : MonoBehaviour
{
    public int timeValue;
    public TextMeshProUGUI timeText;
    bool counting = false;
    // Start is called before the first frame update
    void Start()
    {
        timeValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(counting == false)
        {
            return;
        }
        //on each second add + 1 to timeValue
        //if statememnt to add value to prize
    }
}
