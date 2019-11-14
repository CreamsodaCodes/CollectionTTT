using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Shooting : NetworkBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

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
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        NetworkServer.Spawn(bullet);
        Destroy(bullet, 2);
    }
}
