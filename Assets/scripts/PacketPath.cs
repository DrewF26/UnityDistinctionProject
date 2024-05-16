using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketPath : MonoBehaviour
{
    public GameObject Server;
        
    
    public float speed = 1;
    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        Transform serverTransform = Server.GetComponent<Transform>();
        transform.position = Vector3.MoveTowards(transform.position, serverTransform.position, speed * Time.deltaTime / 5);

    }
        // Start is called before the first frame update

    void Start()
    {
        
    }
}
