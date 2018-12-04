using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsManager : MonoBehaviour {
    public GameObject[] Obstacles;

    private int[] obsRandom = {1,2,4,3};
    public int obsrepeatCount;
    //Dictionary<int, int[]> Test = new Dictionary<int, int[]>();

    public float obstclesetlength = 300f;
    public float SpawnZ = 5f;

    // Use this for initialization
    void Start () {
        for (int x = 0;x < obsrepeatCount; x++)
        {
            ObstcleTile();
        }
        //Test.Add(0,new int[] { 1, 2, 4, 3 });
        //Test.Add(1, new int[] { 2, 1, 4, 3 });
        //Test.Add(2, new int[] { 1, 2, 4, 3 });

        //for(int x = 0;x < Test.Count; x++)
        //{
        //    for(int i = 0;i < Test[x].Length; i++)
        //    {
        //        Debug.Log(Test[x]);
        //    }
        //}

    }

    // Update is called once per frame
    void Update() {
        
	}

    void ObstcleTile()
    {
        for(int x=0; x < obsRandom.Length; x++)
        {
            GameObject gameObject;
            gameObject = Instantiate(Obstacles[x]) as GameObject;
            gameObject.transform.SetParent(transform);
            gameObject.transform.position = new Vector3(0, -3, SpawnZ);
            SpawnZ += obstclesetlength;
        }

    }
}
