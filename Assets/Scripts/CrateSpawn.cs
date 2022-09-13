using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawn : MonoBehaviour {

	public Transform[] spawnPts;
	private int noOfPts;

	public GameObject crate;

	public float timeBetweenWaves = 5f;

	private float timeToSpawn = 5f;

	// Use this for initialization
	void Update () 
	{
		if (Time.time >= timeToSpawn) 
		{
			SpawnBlocks ();
			timeToSpawn = Time.time + timeBetweenWaves;
		}
	}

	void SpawnBlocks()
	{
		noOfPts = spawnPts.Length;

		int randomIndex = Random.Range (0, noOfPts);

		for (int i = 0; i < noOfPts; i++) 
		{
			if (randomIndex == i) 
			{
				Instantiate (crate, spawnPts [i].position, Quaternion.identity);
			}
		}
	}
}
