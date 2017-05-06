using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMag : MonoBehaviour {  
	public GameObject Tank; // the object that will be  using the  points            
	public float spawnTime = 3f;// the  amount  of  time the tank will spawn made  it public for  easy editing           
	public Transform[] spawnPoints; //  the  points  were the  spawn from        

	void Start ()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		//  calls for  the  spawn function at the start of  the  game 
	}
		
	void Spawn ()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		//  founds the points between the spawn points 
		//Debug.Log("Tank are spawn");

		Instantiate (Tank, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
			// create a  instantiate for  the tank for  the  spawn point position and rotation. 
	}
}