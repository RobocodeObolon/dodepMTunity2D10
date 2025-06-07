using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;                      // »грок
    public float smoothSpeed = 5f;                // „ем больше Ч тем быстрее
    public Vector3 offset = new Vector3(0, 0, -10); // Z = -10 об€зательно дл€ 2D

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;

        // ѕлавное движение камеры
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }
}
