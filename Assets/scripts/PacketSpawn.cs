using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject badPacket;
    public bool spawning;
    public GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool timerOn = timer.GetComponent<Counting>().TimerOn;
        float timeUpdate = timer.GetComponent<Counting>().TimeLeft;

        if (timerOn == false)
        {
            return;
        }
        if(spawning == false)
        {
            return;
        }
        if(spawning == true)
        {
            if(timerOn == true)
            {
                Instantiate(badPacket, spawnPoint.position, spawnPoint.rotation);
            }
        }
    }
}
