using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_ship : MonoBehaviour {
    public Transform ship;
    public Vector3 Vector3_offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = ship.position + Vector3_offset;
	}
}
