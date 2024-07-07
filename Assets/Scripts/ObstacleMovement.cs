using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {
	[SerializeField] Rigidbody rb;
	void Awake() {
		rb.velocity = new Vector3(0, 0, -20);
	}

	void Update() {
		if (transform.position.z < -3) {
			Destroy(gameObject);
			GameObject.FindGameObjectWithTag("Spawner").GetComponent<spawnScript>().SpawnRandom();
		}
	}
}
