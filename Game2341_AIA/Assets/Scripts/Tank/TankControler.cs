using UnityEngine;
using UnityEngine.AI;
using System.Collections;

//Tank controller class controll tank movement via navmesh and 
//   firing / attacking the player.
public class TankControler : MonoBehaviour
{
   public float landSpeed = 4.0f;
   public float reloadTime = 5.0f; //Time between targeting and shooting
   public Transform tankTarget;    //Usually the player
   public int damagePerShot = 10;  //Damage to PlayerHeath health if Player hit.
   public float range = 200f;

   private float timer = 0.0f;
   private NavMeshAgent tankDriver;
   //private Transform thisTank;

   private Ray shootRay;
   private RaycastHit shootHit;
   private ParticleSystem gunParticles;
   private LineRenderer gunLine; //used in fire animation
   private Light muzzleFlash;
   //private bool shooting = false;

   // Initialize values and navmesh agent on tank
   //   Start the tank moveing towards the player
   void Start ()
   {
      tankTarget = GameObject.FindGameObjectWithTag ("Player").transform;
      gunLine = GetComponent<LineRenderer> ();
      muzzleFlash = GetComponent<Light> ();
      muzzleFlash.enabled = false;

      tankDriver = GetComponent<NavMeshAgent> ();
      tankDriver.speed = landSpeed;
      tankDriver.destination = tankTarget.position;
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
         tankDriver.destination = tankTarget.position;
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
////        Debug.Log ("tank attack " + tnkCntlr.inWater);
//               shoot ();
//            }
//         }
      }
   }

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
////        Debug.Log ("tank attack: " + shootHit.collider.ToString () + " " + tnkCntlr.inWater);
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
