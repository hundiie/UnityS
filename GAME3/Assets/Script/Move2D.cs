using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float MoveSpeed;
    private Vector3 movedir = Vector3.zero;
    private GameObject GOBB;
    public Camera camera;

    Vector3 V3;
    
    private void Start()
    {
        GOBB = gameObject.transform.GetChild(0).gameObject;
    }
    void Update()
    {
        float X = Input.GetAxisRaw("Horizontal");
        float Y = Input.GetAxisRaw("Vertical");

        movedir = new Vector3(X, Y, 0);

        transform.position += movedir * MoveSpeed * Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            V3 = Input.mousePosition;
            V3 = camera.ScreenToWorldPoint(V3);

            V3.z += 10;
            Debug.Log(V3);
            GameObject bullets = Instantiate(GOBB, transform.position, transform.rotation);
            bullets.SetActive(true);
            bullets.transform.position = V3;
            
        }

    }
}
