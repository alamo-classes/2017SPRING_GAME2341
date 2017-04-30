using System.Collections;
using UnityEngine;
using UnityEngine.AI;

//Tank move class controll tank movement via navmesh
public class TankMove : MonoBehaviour
{
   public float landSpeed = 2.0f;
   public float correctionTime = 5.0f; //Time between targeting and shooting
   public Transform tankTarget;    //Usually the player

   private NavMeshAgent tankDriver;
   private float timer = 0.0f;

   // Initialize values and navmesh agent on tank
   //   Start the tank moveing towards the player
   void Start ()
   {
      tankTarget = GameObject.FindGameObjectWithTag ("Player").transform;
      tankDriver = GetComponent<NavMeshAgent> ();
      tankDriver.speed = landSpeed;
      tankDriver.destination = tankTarget.position;
   }

   // Retartget on current player's position 
   void Update ()
   {
      timer += Time.deltaTime;
      if (timer >= correctionTime)
      {
         timer = 0f;
         // Aim the tank at the new player position
         tankDriver.destination = tankTarget.position;
      }
      if (getDistance () < 10)
         tankDriver.speed = 0;
      else
         tankDriver.speed = landSpeed;
   }

   private float getDistance ()
   {
      float distance = Vector3.Distance (tankTarget.transform.position, transform.position);
      return distance;
   }
}
