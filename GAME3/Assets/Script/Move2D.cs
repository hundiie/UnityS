using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float MoveSpeed;
    private Vector3 movedir = Vector3.zero;

    private GameObject bollet;
    public GameObject playyer;

    public Camera camerat;


    Vector3 mouse_Position;
    Vector3 player_Position;
    
    private void Start()
    {
        bollet = gameObject.transform.GetChild(0).gameObject;
    }
    void Update()
    {
        float X = Input.GetAxisRaw("Horizontal");
        float Y = Input.GetAxisRaw("Vertical");

        mouse_Position = Input.mousePosition;
        mouse_Position = camerat.ScreenToWorldPoint(mouse_Position);
        mouse_Position.z += 10;// 카메라 위치에 보이게

        movedir = new Vector3(X, Y, 0);

        float dx = mouse_Position.x - this.transform.position.x;
        float dy = mouse_Position.y - this.transform.position.y;
        float rotateD = Mathf.Atan2(dy,dx)*Mathf.Rad2Deg;

        this.transform.rotation = Quaternion.Euler(0, 0, rotateD - 90);

        transform.position += movedir * MoveSpeed * Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            Debug.Log(mouse_Position);
            GameObject bullets = Instantiate(bollet,transform.position,transform.rotation);
            bullets.SetActive(true);
            bullets.transform.position = playyer.transform.position;
            
        }

    }
}
