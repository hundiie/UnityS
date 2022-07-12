using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1;
    public float run = 0;
    public GameObject head;

    private bool che = false;

    private void Update()
    {
        if (che == true)
        {
            if (run < 5.0f)
            {
                run += Time.deltaTime;
            }
        }
        else
        {
            if (run > 0)
            {
                run -= Time.deltaTime;
            }
        }

        head.transform.Rotate(0, run, 0);

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
