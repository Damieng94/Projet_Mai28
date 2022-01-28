using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LR : MonoBehaviour //                                          SCRIPT PERMETTANT DE SE DEPLACER SUR L'AXE X
{
    [SerializeField] private float speed; //déplacements
    [SerializeField] private float maxspeed; //déplacement

    private Controls controls; //déplacements
    private float direction; //déplacements
    private SpriteRenderer spriterenderer;
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
    }

    public void OnEnable() //déplacement
    {
        controls = new Controls();
        controls.Enable();
        controls.Deplacement.MoveLR.performed += MoveLRperformed;
    }

    public void MoveLRperformed(InputAction.CallbackContext obj) //déplacements
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

    public  void FixedUpdate() //déplacements
    {
        var horizontalSpeed = Mathf.Abs(rb2D.velocity.x);
        if (horizontalSpeed < maxspeed)
        {
            rb2D.AddForce(new Vector2(speed * direction, 0));
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
