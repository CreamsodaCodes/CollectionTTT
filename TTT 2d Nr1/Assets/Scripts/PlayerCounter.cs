using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerCounter : NetworkBehaviour
{
   public static bool RunningGame = false;
   public static int PlayerCount = 1;
   public static List<int> Traitors = new List<int>();
   

    // Update is called once per frame
    void Update()
    {
        Tratorteilung();
    }

HashSet<int> Tamount = new HashSet<int>();
public void Tratorteilung()
{
    if(Input.GetKeyDown("space"))
    {
        int Speicher = PlayerCount + 1;
        int Speicherklein = Speicher/3;
        
        
        for (int i = 0; i < Speicherklein; i++)
        {
            int Traitor = Random.Range(1, Speicher);
            Traitors.Add(Traitor);
            Debug.Log(Traitor);
            Debug.Log(Speicher);


        }
        RunningGame = true;
    }
}


}
