using System.Collections;
using UnityEngine.UI; //access UI
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //load scenes

public class PlayerHealth : MonoBehaviour {

	public float startingHealth = 10f;
	public Slider healthSlider; //access slider
	public Image hitImage;

	public Color fullHealthColor = Color.green;
	public Color zeroHealthColor = Color.red;

	PlayerController playerController; // access, can't move when health is 0
	MouseLook mouseLook; //can't move camera when health hits zero

	private float currentHealth;
	private bool isDead;

	void Awake()
	{
		playerController = GetComponent <PlayerController> ();
		mouseLook = GetComponent <MouseLook> ();
		hitImage.enabled = false;
		currentHealth = startingHealth;
		SetHealthUI (); //update UI
		isDead = false;
	}

	public void TakeDamage(float amount) //set up health
	{
		currentHealth -= amount;
		SetHealthUI ();
		StartCoroutine (flashHit());
		//Debug.Log ("PH " + currentHealth + " " + amount );
		if (currentHealth <= 0f && !isDead) 
		{
			OnDeath ();
		}
	}

	private void SetHealthUI()
	{
		healthSlider.value = currentHealth;
		//fillImage.color = 
		//	Color.Lerp (zeroHealthColor, fullHealthColor, currentHealth / startingHealth);
	}

	private void OnDeath()
	{
		isDead = true;

		playerController.enabled = false;
		mouseLook.enabled = false;

		SceneManager.LoadScene ("ISG_Level01_Lost");
	}

	private IEnumerator flashHit()
	{
		// Turn on our line renderer
		hitImage.enabled = true;

		//Wait for .07 seconds
		yield return new WaitForSecondsRealtime(.1f);

		// Deactivate our line renderer after waiting
		hitImage.enabled = false;
	}
}
