using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour
{
    public GameObject Player;
 void Update ()
 {
     if (Input.GetButtonDown("Fire2"))
     {
         Shoot();
     }
 }
 void Shoot () {        
         Vector3 startPos = Player.transform.position;
         Vector3 endPos = Player.transform.up * 10;    
         Debug.DrawRay (startPos, endPos);
         RaycastHit hit;
         if (Physics.Raycast (startPos, endPos, out hit)) {
             Debug.Log (hit.transform.name + " was hit");
         }
     }
}
