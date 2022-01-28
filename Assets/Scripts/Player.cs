using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour  //Attache au player avec l'animation + gameobject
{
    [SerializeField] private GameObject jour;

    [SerializeField] private GameObject nuit;

    public SpriteRenderer spriterenderer;

    public Rigidbody2D rb2D;

    public Vector2 raycastDirection;

    public Animator animator;

   void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriterenderer = GetComponent<SpriteRenderer>();
        raycastDirection = Vector2.down;
    }
}
