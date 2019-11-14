using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAttacher : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {
       Debug.Log(other);
       GameObject player = other.gameObject;
       player.GetComponent<Laser>().enabled = true;
         

    }
}
