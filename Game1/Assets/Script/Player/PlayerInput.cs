using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float X { get; private set; }
    public float Y { get; private set; }
    void Update()
    {
        // ���� ���� ������, �⺻ ������ �ʱ�ȭ
        X = Y = 0f;

        X = Input.GetAxisRaw("Horizontal");
        Y = Input.GetAxisRaw("Vertical");

        // ���� �������� �Է� ���� ����
        Debug.Log("PlayerInput Up Start");
    }
}
