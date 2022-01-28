using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spike : MonoBehaviour  //Contient collision piques avec spawnposition pour le player
{
    [SerializeField] Transform SpawnPoint;
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
            collision.transform.position = SpawnPoint.position;
    }
}