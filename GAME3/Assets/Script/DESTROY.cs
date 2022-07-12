using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROY : MonoBehaviour
{
    public float BulletSpeed = 0.05f;
    private void Start()
    {
        Destroy(gameObject, 3.0f);
    }

    private void Update()
    {
        transform.Translate(0f, BulletSpeed, 0f);
    }

}
