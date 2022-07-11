using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1;
    public float time;

    bool che = false;
    void Update()
    {
        if (che == true)
        {
            time += Time.deltaTime;
        }
        else
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
            }
        }
        transform.Rotate(0, time, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            che = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            che = false;
        }
    }
}
