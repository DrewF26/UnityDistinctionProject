using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketPath : MonoBehaviour
{
    public GameObject Server;

    public int Speed;

    private void OnCollisionEnter(Collision collision)
    {
        //if collide with shield do add to score/money/currency

        //if collide with server take damage and disappear

        gameObject.SetActive(false);
    }

    public void MovePacket(int speed)
    {
        Transform serverTransform = Server.GetComponent<Transform>();
        transform.position = Vector3.MoveTowards(transform.position, serverTransform.position, speed * Time.deltaTime / 5);
    }

    void Update()
    {

        MovePacket(Speed);
    }
        // Start is called before the first frame update

    void Start()
    {
        
    }
}
