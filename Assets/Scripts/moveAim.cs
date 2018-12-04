using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAim : MonoBehaviour {
    public Camera aimCamera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(aimCamera.transform.position.x,transform.position.y,transform.position.z); ;
	}
}
