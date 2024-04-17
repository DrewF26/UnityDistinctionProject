using UnityEngine;

public class ShieldCollider : MonoBehaviour
{
    void OnCollisionEnter(Collision CollisionInfo)
    {
        if(CollisionInfo.collider.tag=="Collision Object")
        {
            Debug.Log(CollisionInfo.collider.tag);
        }
    }
}
