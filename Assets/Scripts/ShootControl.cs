using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour {

	private float shootCooldown;

	// Use this for initialization
	void Start () {
		shootCooldown = GetComponent<PlayerController> ().shootCooldown;
		shootCooldown = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
