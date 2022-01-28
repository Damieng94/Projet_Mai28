using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LRcanceled : MonoBehaviour             //           SCRIPT ARRET DE MOUVEMENTS AXE X
{
    private Controls controls;
    private SpriteRenderer spriterenderer;
    public Rigidbody2D rb2D;
    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable() //déplacement
    {
        controls = new Controls();
        controls.Enable();
        controls.Deplacement.MoveLR.canceled += MoveLRcanceled;
    }

    private void MoveLRcanceled(InputAction.CallbackContext obj) //déplacements
    {
        direction = 0;//on arrête de se déplacer 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
