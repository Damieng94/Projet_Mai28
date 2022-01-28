using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SetDayNight : MonoBehaviour                 //SCRIPT PERMETTANT D'ACTIVER/DESACTIVER LE JOUR/NUIT L'UN OU L'AUTRE
{
    [SerializeField] private GameObject jour;

    [SerializeField] private GameObject nuit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Jumpperformed(InputAction.CallbackContext obj)//on saute
    {
        if (jour.activeSelf == true)//si jour actif
        {
            nuit.SetActive(true);//nuit s'active
            jour.SetActive(false);//jour se désactive
        }
        else //sinon
        {
            nuit.SetActive(false);//nuit se désactive
            jour.SetActive(true);//jour s'active
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
