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

    private void OnEnable() //d�placement
    {
        controls = new Controls();
        controls.Enable();
        controls.Deplacement.MoveLR.canceled += MoveLRcanceled;
    }

    private void MoveLRcanceled(InputAction.CallbackContext obj) //d�placements
    {
        direction = 0;//on arr�te de se d�placer 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
