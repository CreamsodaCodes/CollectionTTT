/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Laser : NetworkBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    // public int damage = 10;
    public LineRenderer lineRenderer;
    
    void Update()
    {
        if(!isLocalPlayer){
            return;
        } 
        if (Input.GetButtonDown("Fire1"))
        {
            CmdStarttoShoot();
            
        }
        
    }
            [Command]
    void CmdStarttoShoot()
    {
            StartCoroutine(Shoot());
    }
    IEnumerator Shoot()
    {
        
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.up);
        if (hitInfo)
        {
            

            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, hitInfo.point);
        }
        else
        {
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, firePoint.position + firePoint.up * 100);
        }
        NetworkServer.Spawn(hitInfo);
        lineRenderer.enabled = true;
        yield return new WaitForSeconds(0.7f * Time.fixedDeltaTime );
        lineRenderer.enabled = false;
    }
}*/
