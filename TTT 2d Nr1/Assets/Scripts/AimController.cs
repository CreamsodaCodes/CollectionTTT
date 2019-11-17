using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class AimController : NetworkBehaviour
{
    public Transform controlThisObject; //Here can be the transform of the weapon
     private Vector3 mousePos;
 
     void Update(){
        MouseL();
     }
 
     //Mouse Look script
     void MouseL(){
         if(!isLocalPlayer){
        return;
    }
         //Gets mouse position, you can define Z to be in the position you want the weapon to be in
         mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
         Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
         lookPos = lookPos - transform.position;
         float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg -90f;
         transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
     }
}
