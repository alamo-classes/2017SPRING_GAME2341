using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TankHealth : MonoBehaviour
{
   public float startingHealth = 12f;
   // The amount of health each tank starts with.
   public GameObject explosionPrefab;
   // A prefab that will be instantiated in Awake, then used whenever the tank dies.
   public GameObject tankHit;

   private AudioSource explosionAudio;
   // The audio source to play when the tank explodes.
   private AudioSource hitAudio;
   private ParticleSystem explosionParticles;
   // The particle system the will play when the tank is destroyed.
   private ParticleSystem hitParticles;
   //private TankMove tankControl;

   private float currentHealth;
   // How much health the tank currently has.
   private bool dead;
   // Has the tank been reduced beyond zero health yet?

   private void Awake ()
   {
      // Instantiate the explosion prefab and get a reference to the particle system on it.
      explosionParticles = Instantiate (explosionPrefab).GetComponent<ParticleSystem> ();
      hitParticles = Instantiate (tankHit).GetComponent<ParticleSystem> ();

      // Get a reference to the audio source on the instantiated prefab.
      explosionAudio = explosionParticles.GetComponent<AudioSource> ();
      hitAudio = hitParticles.GetComponent<AudioSource> ();

      // Disable the prefab so it can be activated when it's required.
      explosionParticles.gameObject.SetActive (false);
      hitParticles.gameObject.SetActive (false);

      //tankControl = GetComponent<TankMove> ();
   }


   private void OnEnable ()
   {
      // When the tank is enabled, reset the tank's health and whether or not it's dead.
      currentHealth = startingHealth;
      dead = false;
   }


   public void TakeDamage (float amount)
   {
      // Reduce current health by the amount of damage done.
      currentHealth -= amount;

      // If the current health is at or below zero and it has not yet been registered, call OnDeath.
      if (currentHealth <= 0f && !dead)
      {
         OnDeath ();
      } else
      {
         hitParticles.gameObject.SetActive (false); 
         // Move the instantiated explosion prefab to the tank's position and turn it on.
         hitParticles.transform.position = transform.position;
         hitParticles.gameObject.SetActive (true);

         // Play the particle system of the tank exploding.
         hitParticles.Play ();

         // Play the tank explosion sound effect.
         hitAudio.Play ();
      }
   }

   private void OnDeath ()
   {
      // Set the flag to call function once.
      dead = true;
      // turn off to make sure it plays correctly
      explosionParticles.gameObject.SetActive (false); 
      // Move the instantiated explosion prefab to the tank's position and turn it on.
      explosionParticles.transform.position = transform.position;
      explosionParticles.gameObject.SetActive (true);

      // Play the particle system of the tank exploding.
      explosionParticles.Play ();

      // Play the tank explosion sound effect.
      explosionAudio.Play ();

      //yield return playTime;

      // Turn the tank off.
      gameObject.SetActive (false);
   }
}