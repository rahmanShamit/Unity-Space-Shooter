using UnityEngine;
using System.Collections;
[DisallowMultipleComponent]
public class Explosion : MonoBehaviour {

	[SerializeField]GameObject explosion;


	public void IveBeenHit(Vector3 pos)
	{
		GameObject go = Instantiate (explosion, pos, Quaternion.identity, transform) as GameObject;

		Destroy (go, 6f);
	}



}
