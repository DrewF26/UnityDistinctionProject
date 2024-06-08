using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTotalNumberOfBadPackets : MonoBehaviour
{
    public bool PrintTotalNumberOfBadPackets;
    int TotalNumberOfBadPackets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //puts number of gameobjects with the tag "Bad Packet" into an array and prints the number of items in the array when PrintTotalNumberOfBadPackets == true;
        GameObject[] BadPackets = GameObject.FindGameObjectsWithTag("Bad Packet");
        int totalNumberOfBadPackets = BadPackets.Length;

        if(PrintTotalNumberOfBadPackets == false)
        {
            return;
        }

        if(PrintTotalNumberOfBadPackets == true)
        {
            print(totalNumberOfBadPackets);
            PrintTotalNumberOfBadPackets = false;
        }
    }
}
