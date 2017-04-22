using UnityEngine;
using System.Collections;

public class TankAttack : MonoBehaviour
{
//   public int damagePerShot = 10;
//   public float reloadTime = 6f;
//   public float range = 200f;
//   float timer;
//
//   Ray shootRay;
//   RaycastHit shootHit;
//   ParticleSystem gunParticles;
//   LineRenderer gunLine;
//   Light muzzleFlash;
//   private WaitForSeconds shotDuration = new WaitForSeconds (0.1f);
//   private TankControler tnkCntlr;
//   private bool shooting = false;
//   private float checkTime = 5f;
//   private GameObject tankTarget;
//
//   void Start ()
//   {
//      gunLine = GetComponent<LineRenderer> ();
//      muzzleFlash = GetComponent<Light> ();
//      muzzleFlash.enabled = false;
//      tnkCntlr = GetComponentInParent<TankControler> ();
//      tankTarget = GameObject.FindGameObjectWithTag ("Player");
//   }
//
//
//   void Update ()
//   {
//      timer += Time.deltaTime;
//      if (timer >= checkTime)
//      {
//         timer = 0f;
//         if (!shooting)
//         {
//            shooting = (getDistance () < range);
//            if (shooting)
//            {
//               checkTime = reloadTime;
//               //Debug.Log (shooting);
//            }
//         } else
//         {
//            if (!tnkCntlr.inWater)
//            {
////			Debug.Log ("tank attack " + tnkCntlr.inWater);
//               shoot ();
//            }
//         }
//      }
//   }
//
//   void shoot ()
//   {
//      StartCoroutine (ShotEffect ());
//      gunLine.SetPosition (0, transform.position);
//
//      shootRay.origin = transform.position;
//      shootRay.direction = transform.forward;
//
//      if (Physics.Raycast (shootRay.origin, shootRay.direction, out shootHit, range))
//      {
////			Debug.Log ("tank attack: " + shootHit.collider.ToString () + " " + tnkCntlr.inWater);
////         PlayerHealth health = shootHit.collider.GetComponent<PlayerHealth> ();
////         if (health != null)
////         {
////            health.TakeDamage (damagePerShot);
////         }
////         gunLine.SetPosition (1, shootHit.point);
//      } else
//      {
//         gunLine.SetPosition (1, shootRay.origin + shootRay.direction * range);
//      }
//   }
//
//   private float getDistance ()
//   {
//      float distance = Vector3.Distance (tankTarget.transform.position, transform.position);
//      return distance;
//   }
//
//   private IEnumerator ShotEffect ()
//   {
//      // Turn on our line renderer
//      gunLine.enabled = true;
//      muzzleFlash.enabled = true;
//
//      //Wait for .07 seconds
//      yield return shotDuration;
//
//      // Deactivate our line renderer after waiting
//      gunLine.enabled = false;
//      muzzleFlash.enabled = false;
//   }
}
