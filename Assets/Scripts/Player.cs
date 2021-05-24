using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxspeed;
    [SerializeField] private float jump;
    [SerializeField] private Transform raycaststart;

    private SpriteRenderer spriterenderer;

    private Animator animator;

    private Rigidbody2D rb2D;

    private Controls controls;

    private Vector2 raycastDirection;

    private float direction;


    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Deplacement.MoveLR.performed += MoveLRperformed;
        controls.Deplacement.Jump.performed += Jumpperformed;
        controls.Deplacement.MoveLR.canceled += MoveLRcanceled;
    }

    private void MoveLRperformed(InputAction.CallbackContext obj)
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
        spriterenderer = GetComponent<SpriteRenderer>();
        raycastDirection = Vector2.down;
    }

    private void Jumpperformed(InputAction.CallbackContext obj)
    {
        if (Physics2D.Raycast(raycaststart.position, raycastDirection, 0.1f))
        {
            rb2D.AddForce(jump * transform.up, ForceMode2D.Impulse);



        }
        


    }

    private void MoveLRcanceled(InputAction.CallbackContext obj)
    {
        direction = 0;
    }

    private void FixedUpdate()
    {
        var horizontalSpeed = Mathf.Abs(rb2D.velocity.x);
        if (horizontalSpeed < maxspeed)
        {
            rb2D.AddForce(new Vector2(speed * direction, 0));
        }        
    }
}
