using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

   public bool timer;
  
   
	public class PlayerStatus
    {
        public int Health = 10;
    }
    public PlayerStatus playerstatus = new PlayerStatus();

    public int fallBoundry = -5;

    void Update ()
    {
        Debug.Log(timer);
        if (transform.position.y <= fallBoundry)
        {
            DamagePlayer(99999, timer);
            Debug.Log("DEATH ZONE");
        }
    }

    public void DamagePlayer( int Damage, bool timer )
    {
        playerstatus.Health -= Damage;
        if(playerstatus.Health <= 0)
        {
            
           if (timer == false)
            {
                GetComponent<Animator>().SetBool("Dead", true);
            }
           if (timer == true)
            {
                _GM.KillPlayer(this);
            }
            
            
        }
        
    }

    public IEnumerator Deathanim()
    {
        timer = false;
        yield return new WaitForSeconds(2f);
        timer = true;
        yield return new WaitForSeconds(0);
    }
}
