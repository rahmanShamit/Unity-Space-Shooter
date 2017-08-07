
using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Light))]
[RequireComponent(typeof(LineRenderer))]
[DisallowMultipleComponent]

public class Laser : MonoBehaviour {
	LineRenderer lr;
	Light laserLight;

	bool canFire;

	[SerializeField]float laserOffTime = 0.5f;
	[SerializeField]float maxDistance = 300f;




	void Awake(){
		lr = GetComponent<LineRenderer>();
		laserLight = GetComponent<Light>();
	}


	void Start(){
		lr.enabled = false;
		laserLight.enabled = false;
	}



	void Update(){
		Debug.DrawRay(transform.position, transform.TransformDirection (Vector3.forward) * maxDistance, Color.yellow);
	}




	Vector3 CastRay(){
		RaycastHit hit;

		Vector3 fwd = transform.TransformDirection(Vector3.forward) * maxDistance;

		if (Physics.Raycast (transform.position, fwd, out hit)) {

			Debug.Log ("We hit: " + hit.transform.name); 

			Explosion temp = hit.transform.GetComponent<Explosion> ();

			if (temp != null)
				temp.IveBeenHit (hit.point);
			return hit.point;

		} 

			Debug.Log ("Missed!");
		return transform.position + (transform.forward * maxDistance);

	}




	public void FireLaser(){
		if (canFire) {
			lr.SetPosition (0, transform.position);
			lr.SetPosition (1, CastRay());
			lr.enabled = true;
			laserLight.enabled = true;
			canFire = false;
		}

		Invoke ("turnOffLaser", laserOffTime);
	}



	void turnOffLaser(){
		lr.enabled = false;
		laserLight.enabled = false;

		canFire = true;
	}


	public float Distance
	{
		get { return maxDistance;}
	}
		



}
