using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }

    void Update()
    {
        Debug.Log("���� ���!!");
    }
}
