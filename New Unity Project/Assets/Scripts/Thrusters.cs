
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TrailRenderer))]
[RequireComponent(typeof(Light))]

public class Thrusters : MonoBehaviour {

	TrailRenderer tr;
	Light thrusterLight;


	void Awake(){
		tr = GetComponent<TrailRenderer> ();
		thrusterLight = GetComponent<Light> ();
	}

	void Start(){
		thrusterLight.enabled = false;
		tr.enabled = false;
	}



	public void Activate(bool activate = true){
		if (activate){
			tr.enabled = true;
			thrusterLight.enabled = true;
			// particle effects
			//sound
		}
		else 
		{
			tr.enabled = false;
			thrusterLight.enabled = false;
			//turn off others

		}}



}