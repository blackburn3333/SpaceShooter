using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour {
    public GameObject[] roads;

    //public Transform player;

    public float SpawnZ = 0.0f;
    public float roadLength = 2000f;
    public int roadsAtOnce = 4;

	// Use this for initialization
	void Start () {
        repratTile();
        repratTile();
        repratTile();
        repratTile();
        repratTile();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void repratTile()
    {
        GameObject gameObject;
        gameObject = Instantiate(roads[0]) as GameObject;
        gameObject.transform.SetParent(transform);
        gameObject.transform.position = Vector3.forward * SpawnZ;
        SpawnZ += roadLength;
    }
}
