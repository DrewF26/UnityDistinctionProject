using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketPath : MonoBehaviour
{
    public GameObject Server;
    public GameObject Player;

    public int Speed;

    private void OnTriggerEnter(Collider collision)
    {
        //if collide with shield do add to score/money/currency
        if(collision.CompareTag("Shield"))
        {
            Invoke("Death", 0.1f);
            //increase score
        }
        //if collide with server take damage and disappear

        else if (collision.CompareTag("Shield"))
        {
            PlayerHealth health = Player.GetComponent<PlayerHealth>();
            health.UpdateHealth(-5);
            Invoke("Death", 0.1f);
            //decrease score
        }

        Invoke("Death", 0.1f);
    }

    void Death()
    {
        Destroy(gameObject);
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
