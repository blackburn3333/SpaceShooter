using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBoundry : MonoBehaviour {
    public Rigidbody player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "shipBoundry")
        {
            Debug.Log("Hit");
            player.freezeRotation = true;
        }
    }
}
