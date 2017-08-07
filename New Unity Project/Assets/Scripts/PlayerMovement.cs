using UnityEngine;
using System.Collections;


[DisallowMultipleComponent]
	public class PlayerMovement : MonoBehaviour {
	[SerializeField]float movementSpeed = 50f;
	[SerializeField]float turnSpeed = 60f;
	[SerializeField]Thrusters[] thrusters;

		Transform myT;

		void Awake(){
			myT = transform;
		}

		void Update(){
		Turn();
		Thrust();
		}

	void Turn(){
		float yaw = turnSpeed * Time.deltaTime * Input.GetAxis ("Horizontal");
		float pitch = turnSpeed * Time.deltaTime * Input.GetAxis ("Pitch");
		float roll = turnSpeed * Time.deltaTime * Input.GetAxis ("Roll");

		myT.Rotate (pitch, yaw, roll);
	
	}

		void Thrust(){
		//when ship thrusts, call Thrusters.Activate, otherwise call Thrusters.Activate(false).

			if (Input.GetAxis ("Vertical") > 0)
			
				myT.position += myT.forward * movementSpeed * Time.deltaTime * Input.GetAxis ("Vertical");

		if (Input.GetKeyDown (KeyCode.W))
			foreach (Thrusters t in thrusters)
				t.Activate ();
		else if (Input.GetKeyUp (KeyCode.W))
			foreach (Thrusters t in thrusters)
				t.Activate (false);
		}


}

