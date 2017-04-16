using System.Collections;
using UnityEngine.UI; //access UI
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //load scenes

public class PlayerHeath : MonoBehaviour {

	public float startingHealth = 10f;
	public Slider healthSlider; //access slider
	public Image FillImage;
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

		currentHealth = startingHealth;
		SetHealthUI (); //update UI

		isDead = false;
	}

	public void TakeDamage(float amount) //set up health
	{
		currentHealth -= amount;

		SetHealthUI ();

		if (currentHealth <= 0f && !isDead) 
		{
			OnDeath ();
		}
	}

	private void SetHealthUI()
	{
		healthSlider.value = currentHealth;

		FillImage.color = 
			Color.Lerp (zeroHealthColor, fullHealthColor, currentHealth / startingHealth);
	}

	private void OnDeath()
	{
		isDead = true;

		playerController.enabled = false;
		mouseLook.enabled = false;

		SceneManager.LoadScene ("ISG_Level01_Lost");
	}
}
