using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COPY : MonoBehaviour
{
    private GameObject Sphere;

    private void Start()
    {
        Sphere = GetComponent<GameObject>();
    }
    private void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(" ��ġ��");

        if (other.tag == "WALL")
        {
            Instantiate(Sphere, transform.position, transform.rotation);

            Debug.Log(" �� ��ġ��");
        }
    }
}
