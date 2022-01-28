using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpPerformed : MonoBehaviour
{
    [SerializeField] private float jump; //saut
    [SerializeField] private Transform raycaststart; //saut

    private Controls controls;
    private SpriteRenderer spriterenderer;
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
    }
    private void OnEnable() //déplacements
    {
        controls = new Controls();
        controls.Enable();
    //    controls.Deplacement.Jump.performed += Jumpperformed;
    }
    
    /*public void Jumpperformed(InputAction.CallbackContext obj) //saut
    {
        if (Physics2D.Raycast(raycaststart.position, raycastDirection, 0.1f))                             //Ne fonctionne pas, je souhaitais récuperer le raycast/utiliser le raycast
        {
            rb2D.AddForce(jump * transform.up, ForceMode2D.Impulse);
        }
    }*/

    // Update is called once per frame
     void Update()
    {
        
    }
}
