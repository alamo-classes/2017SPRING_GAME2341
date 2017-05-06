using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {

	public AudioSource jumpSound;

	// Use this for initialization
	void Start () {
		//If the player jumps, play the jump sound
		if (Input.GetKeyDown (KeyCode.Space)) {
			jumpSound.Play ();
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
