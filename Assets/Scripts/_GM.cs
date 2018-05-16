using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GM : MonoBehaviour {
    
    public static _GM gm;
    void Start ()
    {
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<_GM>();
        }
        
    }

    public Transform playerPrefab;
    public Transform spawnPoint;
    public int spawnDelay = 2;

    public IEnumerator RespawnPlayer ()
    {
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        Debug.Log("TO DO: ADD SPAWNING EFFECT");
    }
    public static void KillPlayer (PlayerStats playerstats) 
    {
        Destroy (playerstats.gameObject);

        gm.StartCoroutine(gm.RespawnPlayer());
    }
	
}
