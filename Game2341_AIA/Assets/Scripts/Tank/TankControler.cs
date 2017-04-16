using UnityEngine;
using System.Collections;

public class TankControler : MonoBehaviour
{
    public float landSpeed = 1.0f;
    public float waterSpeed = 0.3f;
    private GameObject tankTarget;

    public bool inWater = false;
    private Transform thisTank;
    private float tankSpeed;

    void Start()
    {
        tankTarget = GameObject.FindGameObjectWithTag("Player");
        thisTank = transform;
        tankSpeed = landSpeed;
    }

    void FixedUpdate()
    { // move to and shoot at target
        float travel = tankSpeed * Time.fixedDeltaTime;
        turnToTarget();
        thisTank.position = Vector3.MoveTowards(thisTank.position, tankTarget.transform.position, travel);
    }

    void OnCollisionEnter(Collision objct)
    {
		if(objct.gameObject.tag == "Player")
		{
			tankSpeed = 0;
		}
	}

	void OnTriggerEnter(Collider objct)
	{
		if(objct.gameObject.tag == "Water")
		{
			inWater = true;
			tankSpeed = waterSpeed;
			this.tag = "TankWet";
		}
	}

    void OnCollisionExit(Collision objct)
    {
		if(objct.gameObject.tag == "Player")
		{
			tankSpeed = landSpeed;
		}
	}

	void OnTriggerExit(Collider objct)
	{
		if(objct.gameObject.tag == "Water")
		{
			inWater = false;
			tankSpeed = landSpeed;
			this.tag = "EnemyTank";
		}
	}

    void turnToTarget()
    {
        thisTank.rotation = Quaternion.LookRotation(tankTarget.transform.position - thisTank.position);
        thisTank.Rotate(0, -90, 0);
    }
}
