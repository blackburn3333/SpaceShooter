﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaMove : MonoBehaviour {
    public Transform player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z);
    }
}
