using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject prefabToSpawn;
    public float spawnInterval;
    public int numberToSpawn;

    private float startTime;
    private bool infinite = false;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
        if(numberToSpawn == 0)
        {
            infinite = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > startTime + spawnInterval){
            if(infinite || numberToSpawn > 0)
            {
                Instantiate(prefabToSpawn, transform.position, transform.rotation);
                numberToSpawn--;
                startTime = Time.time;
            }
        }
	}
}
