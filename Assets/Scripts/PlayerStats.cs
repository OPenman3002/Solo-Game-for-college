using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
    

  
   
	public class PlayerStatus
    {
        public int Health = 10;
    }
    public PlayerStatus playerstatus = new PlayerStatus();

    public int fallBoundry = -5;

    void Update ()
    {
        if (transform.position.y <= fallBoundry)
        {
            DamagePlayer(99999);
            Debug.Log("DEATH ZONE");
        }
    }

    public void DamagePlayer( int Damage )
    {
        playerstatus.Health -= Damage;
        if(playerstatus.Health <= 0)
        {
           
            _GM.KillPlayer(this);
            
        }
    }
}
