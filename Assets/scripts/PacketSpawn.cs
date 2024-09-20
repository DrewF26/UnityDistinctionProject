using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject badPacket;
    public GameObject goodPacket;
    bool spawning;
    bool spawnGood;
    public GameObject timer;
    public bool AllowSpawning;
    public bool AllowGoodSpawning;
    public float iSpawnInterval;
    public float fSpawnInterval;
    float SpawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        spawning = true;
        spawnGood = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnInterval = Random.Range(iSpawnInterval, fSpawnInterval);
        //move on x-axis
        bool timerOn = timer.GetComponent<Counting>().TimerOn;
        if (AllowGoodSpawning == false)
        {
            return;
        }
        if (AllowGoodSpawning == true)
        {
            if (timerOn == false)
            {
                return;
            }
            if (spawnGood == false)
            {
                return;
            }
            if (timerOn == true)
            {
                if (spawnGood == true)
                {
                    SpawnGoodGuys();
                }
            }
        }
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
    void SpawnGoodTrue()
    {
        spawnGood = true;
    }
    void SpawnBadGuys()
    {

        bool timerOn = timer.GetComponent<Counting>().TimerOn;

        if (timerOn == true)
        {
            Instantiate(badPacket, spawnPoint.position, spawnPoint.rotation);
            spawning = false;
            Invoke("SpawnTrue", SpawnInterval);
            Invoke("SpawnBadGuys", SpawnInterval);
        }
    }
    void SpawnGoodGuys()
        {
            bool timerOn = timer.GetComponent<Counting>().TimerOn;

            if(timerOn == true)
            {
                Instantiate(goodPacket, spawnPoint.position, spawnPoint.rotation);
                spawnGood = false;
                Invoke("SpawnGoodTrue", SpawnInterval);
                Invoke("SpawnGoodGuys", SpawnInterval);

            }
        }
    }
    //IEnumerator Wait()
    //{

    //    yield return new WaitForSecondsRealtime(5);

    //}


