using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    
    private float atDeathTime = 2f;

    GameObject elevator_0;
    Animator eleAnim;
    Animator anim;
	public class PlayerStatus
    {
         public int Health = 10;
    }
    public PlayerStatus playerstatus = new PlayerStatus();

    public int fallBoundry = -5;

    void Update ()
    {
        
        
        anim = gameObject.GetComponent<Animator>();
        
    }

    public void DamagePlayer( int Damage )
    {
        playerstatus.Health -= Damage;
        if (playerstatus.Health <= 0)
        {

            GetComponent<Animator>().SetBool("Dead", true);
           

        }
            
            
        }
    public void KillDude()
    {
        GetComponent<Animator>().SetBool("Dead", false);
        _GM.KillPlayer(this);
        
    }    
    
    }

   // public IEnumerator Deathanim()
   // {
       // timer = false;
      //  yield return new WaitForSeconds(2f);
      //  timer = true;
       // yield return new WaitForSeconds(0);
    //}

