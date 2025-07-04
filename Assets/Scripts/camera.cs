using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;                      // �����
    public float smoothSpeed = 5f;                // ��� ������ � ��� �������
    public Vector3 offset = new Vector3(0, 0, -10); // Z = -10 ����������� ��� 2D

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;

        // ������� �������� ������
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }
}
