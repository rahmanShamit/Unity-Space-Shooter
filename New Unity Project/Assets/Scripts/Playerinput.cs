using UnityEngine;
using System.Collections;

public class Playerinput : MonoBehaviour {

	[SerializeField]Laser[] laser;



	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			foreach (Laser l in laser) {
	//			Vector3 pos = transform.position + (transform.forward * l.Distance);
				l.FireLaser ();
			}
		}
	}

			





}
