using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ShotGunSpawner : NetworkBehaviour
{
   public GameObject shotgunPrefab;
    public GameObject laserPrefab;

   public int NumberOfShotguns;
    public int NumberOfLaser;

   
   public override void OnStartServer()
   {
       for(int i = 0; i < NumberOfShotguns; i++)
       {
           Vector2 spawnPosition = new Vector2(Random.Range(-8.0f,8.0f),Random.Range(-8.0f,8.0f));
           Quaternion spawnRotation = Quaternion.Euler(0.0f,Random.Range(0.0f,180.0f),0 );

           GameObject shotgun = (GameObject) Instantiate(shotgunPrefab, spawnPosition, spawnRotation);
           NetworkServer.Spawn(shotgun);
       }
       for(int i = 0; i < NumberOfShotguns; i++)
       {
           Vector2 spawnPosition = new Vector2(Random.Range(-8.0f,8.0f),Random.Range(-8.0f,8.0f));
           Quaternion spawnRotation = Quaternion.Euler(0.0f,Random.Range(0.0f,180.0f),0 );

           GameObject Laser = (GameObject) Instantiate(laserPrefab, spawnPosition, spawnRotation);
           NetworkServer.Spawn(Laser);
       }
   } 
}
