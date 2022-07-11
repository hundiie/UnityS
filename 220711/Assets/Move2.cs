using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public float speed = 1;
    public float moveSpeed = 0.1f;
    Rigidbody RB;
    Move aa;
    void Update()
    {
        aa = GetComponent<Move>();
        RB = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.Space))
        {
            RB.AddForce(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            RB.AddForce(-moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            RB.AddForce(moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            RB.AddForce(0, 0, moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            RB.AddForce(0, 0, -moveSpeed);

        }
    }
}
