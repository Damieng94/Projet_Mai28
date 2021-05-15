using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jump;
    [SerializeField] private float rollForce;
    [SerializeField] private Transform RaycastStartTransform;

    private SpriteRenderer spriterenderer;
    
    private Animator animator;

    private Rigidbody2D rb2D;

    private Controls controls;

    private float direction;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Deplacement.LeftRight.performed += LeftRight;
        controls.Deplacement.Space.performed += Space;
        controls.Deplacement.LeftRight.canceled += LeftRightCanceled;
    }

    private void LeftRightCanceled(InputAction.CallbackContext obj)
    {
        direction = 0;
    }

    private void LeftRight(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<float>();
        if (direction > 0)
        {
            spriterenderer.flipX = false;
        }
        else
        {
            spriterenderer.flipX = true;
        }
    }

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Space(InputAction.CallbackContext obj)
    {
        rb2D.gravityScale *= -1;
    }
}
