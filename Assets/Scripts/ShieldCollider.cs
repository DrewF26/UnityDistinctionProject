using UnityEngine;

public class ShieldCollider : MonoBehaviour
{

    public int CollisionCount = 0;
    public bool Detecting = false;

    // starts shield collision detection
    public void StartCollisionDetect(bool detect)
    {
        Detecting = detect;
    }

    void OnCollisionEnter(Collision CollisionInfo)
    {
        // stops script if Detecting == false
        if (Detecting == false)
        {
            return;
        }
        // logs when shield collides with "Collision Object"
        if(CollisionInfo.collider.tag=="Collision Object")
        {
            Debug.Log(CollisionInfo.collider.tag);

            CollisionCount += 1;

            Debug.Log(CollisionCount);
        }

        if (CollisionInfo.collider.tag == "Cylinder")
        {
            Debug.Log(CollisionInfo.collider.tag);
        }
    }
}
