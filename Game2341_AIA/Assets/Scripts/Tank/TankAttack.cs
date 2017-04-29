using UnityEngine;
using UnityEngine.AI;
using System.Collections;

//Tank Attack class does firing / attacking the player.
public class TankAttack : MonoBehaviour
{
	public float reloadTime = 5.0f;
	//Time between targeting and shooting
	public Transform tankTarget;
	//Usually the player
	public int damagePerShot = 10;
	//Damage to PlayerHeath health if Player hit.
	public float range = 200f;

	private float timer = 0.0f;
	private Transform thisTank;

	private RaycastHit shootHit;
	private ParticleSystem gunParticles;
	private LineRenderer gunLine;
	//used in fire animation
	private Light muzzleFlash;
	private bool shooting = false;

	// Initialize values
	void Start ()
	{
		tankTarget = GameObject.FindGameObjectWithTag ("Player").transform;
		gunLine = GetComponent<LineRenderer> ();
		muzzleFlash = GetComponent<Light> ();
		muzzleFlash.enabled = false;
		thisTank = this.GetComponent<Transform> ();
	}

	// Retartget on current player's position and shot if in range
	//   Shoot once every retarget check - reload time.
	void Update ()
	{
		timer += Time.deltaTime;
		if (timer >= reloadTime)
		{
			timer = 0f;
			// Aim the tank at the new player position
			if (!shooting)
			{
				shooting = (getDistance () < range);
			} else
			{
				shoot ();
			}
			//Debug.Log ("shooting " + shooting);
		}
	}

	void shoot ()
	{
		//turnToTarget (); // correct for navemesh errors
		StartCoroutine (ShotEffect ());
		gunLine.SetPosition (0, thisTank.position);

		//transform.position;
		//transform.LookAt(tankTarget);
		Vector3 heading = tankTarget.transform.position - thisTank.position;
		//heading.normalized;

		if (Physics.Raycast (thisTank.position, heading.normalized, out shootHit, range))
		{
			//Debug.Log ("tank attack: " + shootHit.collider.ToString ());
			PlayerHealth health = shootHit.collider.GetComponent<PlayerHealth> ();
			if (health != null)
			{
				health.TakeDamage (damagePerShot);
			}

			gunLine.SetPosition (1, thisTank.position + heading.normalized * range);
			//Debug.Log ("tank attack: " + gunLine.ToString ());
		} else
		{
			gunLine.SetPosition (1, thisTank.position + heading.normalized * range);
			//Debug.Log ("tank attack: " + gunLine.ToString ());
		}
	}

	private float getDistance ()
	{
		float distance = Vector3.Distance (tankTarget.transform.position, transform.position);
		return distance;
	}

	private IEnumerator ShotEffect ()
	{
		// Turn on our line renderer
		gunLine.enabled = true;
		muzzleFlash.enabled = true;

		//Wait for .07 seconds
		yield return new WaitForSecondsRealtime(.1f);

		// Deactivate our line renderer after waiting
		gunLine.enabled = false;
		muzzleFlash.enabled = false;
	}

	void turnToTarget ()
	{
		this.transform.rotation = Quaternion.LookRotation (tankTarget.transform.position - this.transform.position);
		this.transform.Rotate (0, 0, 0);
	}

}
