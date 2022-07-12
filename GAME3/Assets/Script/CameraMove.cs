using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Player;

    private Vector3 V3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        V3 = Player.transform.position;
        V3.z -= 10;
        Camera.transform.position = V3;
    }
}
