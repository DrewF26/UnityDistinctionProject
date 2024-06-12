using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOfImportantObjects: MonoBehaviour
{
    public bool PrintObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //puts number of gameobjects with the tag "Bad Packet" into an array and prints the number of items in the array when PrintObjects == true;
        GameObject[] BadPackets = GameObject.FindGameObjectsWithTag("Bad Packet");
        int NumberOfBadPackets = BadPackets.Length;
        GameObject[] GoodPackets = GameObject.FindGameObjectsWithTag("Good Packet");
        int NumberOfGoodPackets = GoodPackets.Length;
        GameObject[] Servers = GameObject.FindGameObjectsWithTag("Server");
        int NumberOfServers = Servers.Length;

        if(PrintObjects == false)
        {
            return;
        }

        if(PrintObjects == true)
        {
            print(NumberOfBadPackets + " Bad Packets, " + NumberOfGoodPackets + "Good Packets " + NumberOfServers + "Servers");
            PrintObjects = false;
        }
    }
}
