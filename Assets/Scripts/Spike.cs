using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spike : MonoBehaviour
{
    [SerializeField] Transform SpawnPoint;
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
            collision.transform.position = SpawnPoint.position;
    }
}