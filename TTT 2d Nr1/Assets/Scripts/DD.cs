using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

//Ist das Player Script welches man nicht deaktivieren sollte.
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
private int myNumber;
private bool Traitor = false;
private bool CheckNeeded = true;


public void TraitorCheck()
{
    
    if(PlayerCounter.Traitors.Contains(myNumber))
    {
        Traitor = true;
        CheckNeeded = false;
        farbe.color = Color.blue;
        Debug.Log(CheckNeeded);
        Debug.Log("myNum" + myNumber);
    }
    else
    {
        //Falls wir noch einen Inno boolien bräuchten
        CheckNeeded = false;
        
    }
}
private void Start() {
    rb = GetComponent<Rigidbody2D> ();
    //Gibt jedem Player eine Nummer für den Inno Traitor verteiler
    PlayerCounter.PlayerCount += 1;
    //Merkt sich die eigene Nummer damit man sie später abgleichen kann, da PlayerCount static ist
    myNumber = PlayerCounter.PlayerCount;
}

private void Update() {
    if(!isLocalPlayer){
        return;
    }
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");
    //Startet den Verteiler für alle Player
    if(PlayerCounter.RunningGame && CheckNeeded)
    {
        TraitorCheck();
    }
    
    
}
private void FixedUpdate() {
    if(!isLocalPlayer){ return; }
        
    
     rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime );

     
    


}
public override void OnStartLocalPlayer(){
    //Ändert die Farbe des eigenen Players
    farbe = GetComponent<SpriteRenderer>();
    farbe.color = Color.red;
    //Weißt jedem Player seine Kamera zu
    Camera.main.GetComponent<CameraController>().setTarget(gameObject.transform);
    

   
}

HashSet<int> Tamount = new HashSet<int>();
public void Tratorteilung()
{

}




}