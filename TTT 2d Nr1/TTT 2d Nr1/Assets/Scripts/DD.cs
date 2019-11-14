﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class DD : NetworkBehaviour
{
private Rigidbody2D rb;
private Rigidbody2D bulletRb;
private Vector2 movement;
Vector2 mousePos;
public float moveSpeed = 5;
SpriteRenderer farbe;
public GameObject bulletPrefab;
public Transform bulletSpawn;
public Camera cam;


private void Start() {
    rb = GetComponent<Rigidbody2D> ();
}

private void Update() {
    if(!isLocalPlayer){
        return;
    }
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");
    

    
}
private void FixedUpdate() {
    if(!isLocalPlayer){ return; }
        
    
     rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime );

     
    


}
public override void OnStartLocalPlayer(){
    farbe = GetComponent<SpriteRenderer>();
    farbe.color = Color.red;
    Camera.main.GetComponent<CameraController>().setTarget(gameObject.transform);
   
}
void Fire(){
    GameObject bullet = (GameObject) Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
    bulletRb = GetComponent<Rigidbody2D>();
    bulletRb.velocity = bullet.transform.forward * 6.0f;
    Destroy(bullet, 2);
}





}