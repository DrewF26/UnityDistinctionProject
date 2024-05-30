using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMovement : MonoBehaviour
{
    private Vector3 StartPos;
    private Vector3 EndPos;
    private float MoveDistance = 1.7f;
    private float MoveSpeed = 1.37f;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;

        EndPos = StartPos + Vector3.right * MoveDistance;
    }

    // Update is called once per frame
    void Update()
    {
        float NewXPos = Mathf.PingPong(Time.time * MoveSpeed / MoveDistance, 1); // PingPong for oscillating between 0 and 1
        transform.position = Vector3.Lerp(StartPos, EndPos, NewXPos);

    }
}
