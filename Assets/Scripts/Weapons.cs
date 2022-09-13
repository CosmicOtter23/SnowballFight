using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour {

	public GameObject[] weapons;

	private float fireRate;

	//public GameObject player1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RandWeapon(int weaponNo, Transform player)
	{
		weapons [weaponNo].SetActive (true);

		Instantiate (weapons[weaponNo], player.position, Quaternion.identity);
	}
}
