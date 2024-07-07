using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour {
	public GameObject[] obstacles;

    public void SpawnRandom() {
        Instantiate(obstacles[Random.Range(0, obstacles.Length)]);
    }
}
