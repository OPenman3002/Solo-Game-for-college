﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour {
    public int moveSpeed = 230;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate (Vector3.right * Time.deltaTime * moveSpeed );
        Destroy(this.gameObject, 1);
	}
}
