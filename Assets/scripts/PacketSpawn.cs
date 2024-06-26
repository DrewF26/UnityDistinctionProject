using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject badPacket;
    bool spawning;
    public GameObject timer;
    public bool AllowSpawning;
    public float SpawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        spawning = true;

        
    }

    // Update is called once per frame
    void Update()
    {

        //move on x-axis

        bool timerOn = timer.GetComponent<Counting>().TimerOn;

        if(AllowSpawning == false)
        {
            return;
        }
        if(AllowSpawning == true)
        {
            if (timerOn == false)
            {
                return;
            }
            if (spawning == false)
            {
                return;
            }
            if (timerOn == true)
            {
                if (spawning == true)
                {
                    SpawnBadGuys();
                }
            }
        }
    }

    void SpawnTrue()
    {
        spawning = true;
    }
    void SpawnBadGuys()
    {
        
        bool timerOn = timer.GetComponent<Counting>().TimerOn;

        if(timerOn == true)
        {
            Instantiate(badPacket, spawnPoint.position, spawnPoint.rotation);
            spawning = false;
            Invoke("SpawnTrue", SpawnInterval);
            Invoke("SpawnBadGuys", SpawnInterval);
        }
    }
    //IEnumerator Wait()
    //{

    //    yield return new WaitForSecondsRealtime(5);

    //}
}

