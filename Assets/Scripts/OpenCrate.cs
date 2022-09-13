using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCrate : MonoBehaviour {

	public GameObject openEffect;

	public Transform player1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player1") {
			int random = Random.Range (0, 1);

			FindObjectOfType<Weapons> ().RandWeapon(random, player1);

			Instantiate (openEffect, transform.position, transform.rotation);

			Destroy (gameObject);
		}
	}
}
