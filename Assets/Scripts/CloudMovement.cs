using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour {

	public float moveSpeed;

	public float height;

	private Rigidbody2D rigid;

	private float xPosition;

	public float maxPosition;
	public float minPosition;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		xPosition = rigid.position.x;

		if (xPosition >= maxPosition) {
			transform.position = new Vector3 (minPosition, height, 0.0f);
		} else {
			rigid.velocity = new Vector2 (moveSpeed, 0);
		}
	}
}
