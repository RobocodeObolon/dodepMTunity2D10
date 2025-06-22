using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        // ������ ������� ������ ���� ��� ���
        animator.SetBool("isWalking", moveInput != 0);

        // ������������ �������
        if (moveInput > 0)
        {
            spriteRenderer.flipX = false; // �������� ������
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = true; // �������� ����
        }
    }
}
