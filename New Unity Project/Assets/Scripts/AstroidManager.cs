using UnityEngine;
using System.Collections;

public class AstroidManager : MonoBehaviour {
	[SerializeField]Asteroids asteroid;
	[SerializeField]int numberofAsteroidsonanAxis = 10;
	[SerializeField]int gridSpacing = 100;

	void Start(){
		placeAsteroids();
	}

	void placeAsteroids(){
		for (int x = 0; x < numberofAsteroidsonanAxis; x++) {
			
			for (int y = 0; y < numberofAsteroidsonanAxis; y++) {
				
				for (int z = 0; z < numberofAsteroidsonanAxis; z++) {
					InstantiateAsteroid (x, y, z);
				}
			}
		}
	}


	void InstantiateAsteroid(int x, int y, int z){
		Instantiate (asteroid, 
			new Vector3(transform.position.x + (x*gridSpacing) + AsteroidOffset(), 
				        transform.position.y + (y*gridSpacing) + AsteroidOffset(), 
				        transform.position.z + (z*gridSpacing) + AsteroidOffset()), 
	    Quaternion.identity, 
	    transform);
	}


	float AsteroidOffset(){
		return Random.Range (-gridSpacing / 2f, gridSpacing / 2f);
	}
}
