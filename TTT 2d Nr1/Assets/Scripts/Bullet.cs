using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  public int Dmg = 10;
      void OnTriggerEnter2D(Collider2D other) 
    {
        GameObject hit = other.gameObject;
        Health health = hit.GetComponent<Health>();
        if(health != null)
        {
          health.TakeDamage(Dmg);
          Debug.Log("Getroffen");
        }
        //Destroy(gameObject);
        
    }
}
