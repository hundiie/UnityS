using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public float UpSpeed = 1;
    public float moveSpeed = 0.1f;
    public float rotateSpeed = 0.1f;
    
    Rigidbody RB;
    Move mv;
    private void Start()
    {
        mv = gameObject.GetComponent<Move>();
        RB = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float inrun = mv.run;

        if (inrun > 3.0f)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                RB.AddForce(0, UpSpeed, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                RB.transform.Translate(-moveSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                RB.AddForce(moveSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, rotateSpeed, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -rotateSpeed, 0);
            }
        }
    }
}
