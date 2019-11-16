using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class Sniper : NetworkBehaviour
{
   public Transform firePoint2;
    public GameObject bulletPrefab2;
    public float x = 1.0f;

    public float bulletForce2 = 20f;

    // Update is called once per frame
    void Update()
    {
        if(!isLocalPlayer){
            return;
        } 
        if(Input.GetButtonDown("Fire1")){
            CmdShoot();
        }
    }
    [Command]
    void CmdShoot(){
       for(int i = 1; i < 4; i++)
       { 
        GameObject bullet2 = Instantiate(bulletPrefab2, firePoint2.position * x, firePoint2.rotation);
        Rigidbody2D rb = bullet2.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint2.up * bulletForce2, ForceMode2D.Impulse);
        NetworkServer.Spawn(bullet2);
        Destroy(bullet2, 2);
        x *= 1.1f;
       }
       x = 1;
    }
}
