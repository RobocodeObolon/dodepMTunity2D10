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

        // Включає анімацію ходьби якщо йде рух
        animator.SetBool("isWalking", moveInput != 0);

        // Перевертання спрайту
        if (moveInput > 0)
        {
            spriteRenderer.flipX = false; // дивиться вправо
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = true; // дивиться вліво
        }
    }
}
