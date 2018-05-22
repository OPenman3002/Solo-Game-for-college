using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GM : MonoBehaviour {
    public GameObject elevator_0;
     public Animator anim;
    public static _GM gm;
    void Start ()
    {
        
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<_GM>();
        }
        anim = elevator_0.GetComponent<Animator>();
        anim.SetBool("NotInUse", true);
        
    }

    public Transform playerPrefab;
    public Transform spawnPoint;
    public int spawnDelay = 2;

    public IEnumerator RespawnPlayer ()
    {
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        
        anim.SetBool("NotInUse", false); 
        Debug.Log("TO DO: ADD SPAWNING EFFECT");
        
        
    }
    public static void KillPlayer (PlayerStats playerstats ) 
    {
        Destroy (playerstats.gameObject);

        gm.StartCoroutine(gm.RespawnPlayer());
        

    }
	
}
