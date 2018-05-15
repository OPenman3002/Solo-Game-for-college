using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GM : MonoBehaviour {
       
    public static void KillPlayer (PlayerStats playerstats) 
    {
        Destroy (playerstats.gameObject);
    }
	
}
