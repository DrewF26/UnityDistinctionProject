using UnityEngine;

public class ServerCollider : MonoBehaviour
{

    public int CollisionCount = 0;
    public bool Detecting = false;
    PlayerHealth healthScript;

    void Start()
    {
        healthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // starts server collision detection
    public void StartCollisionDetect(bool detect)
    {
        //starts server game
        Detecting = detect;
    }

    void OnCollisionEnter(Collision CollisionInfo)
    {
        // stops script if Detecting == false
        if (Detecting == false)
        {
            return;
        }
        // logs when server collides with "Collision Object"
        if(CollisionInfo.collider.tag== "Bad Packet")
        {
            
            healthScript.UpdateHealth(-2);
            //Collision Object disapears
        }
      
        if (CollisionInfo.collider.tag == "Good Packet")
        {

            healthScript.UpdateHealth(3);
        }
    }
}
