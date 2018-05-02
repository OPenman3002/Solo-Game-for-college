using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {
    public float fireRate = 0;
    public float damage = 10;
    public LayerMask notToHit;

    float timeToFire = 0;
    Transform bulletExit;
	// Use this for initialization
	void Awake () {
        bulletExit = transform.Find ("bulletExit");
		if (bulletExit = null) {
            Debug.LogError("No firepoint? WHAT!?");
        }
	}
	
	// Update is called once per frame
	void Update () {
		if (fireRate == 0)
        {
           if (Input.GetButtonDown ("Fire1"))
                {
                Shoot(); 
                }
        }
        else
        {
            if (Input.GetButton("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
	}
    void Shoot ()
    {
        Debug.Log("Test");
    }
}
