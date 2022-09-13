using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	public float ballSpeed;

	private Rigidbody2D theRB;

	public GameObject projectileEffect;

	public float rotationSpeed;

	public int damage;

	// Use this for initialization
	void Start () {
		theRB = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		theRB.velocity = new Vector2 (ballSpeed * transform.localScale.x, 0);

		theRB.angularVelocity = rotationSpeed * transform.localScale.x;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player1") {
			FindObjectOfType<GameManager> ().HurtP1(damage);
		}

		if (other.tag == "Player2") {
			FindObjectOfType<GameManager> ().HurtP2(damage);
		}

		Instantiate (projectileEffect, transform.position, transform.rotation);

		Destroy (gameObject);
	}
}
