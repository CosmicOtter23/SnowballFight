using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	public int p1Life;
	public int p2Life;

	public GameObject p1Wins;
	public GameObject p2Wins;

	public Slider p1Slider;
	public Slider p2Slider;

	public AudioSource hurtSound;

	public string mainMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (p1Life <= 0) {
			player1.SetActive (false);
			p2Wins.SetActive (true);
		}

		if (p2Life <= 0) {
			player2.SetActive (false);
			p1Wins.SetActive (true);
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene (mainMenu);
		}
	}

	public void HurtP1 (int damage){
		p1Life -= damage;

		p1Slider.value = p1Life;

		hurtSound.Play ();
	}
			
	public void HurtP2 (int damage){
		p2Life -= damage;

		p2Slider.value = p2Life;

		hurtSound.Play ();
	}
}
