using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanet : MonoBehaviour
{
	public GameObject[] planetPrefab;

	public int maxPlanet = 5;
	public int countPlanet = 0;

	public float timeSpawn = 5f;
	private float timer;

	public Vector3 whereToSpawn;

	public float randX;
	public float randY;
	public float randZ;
	// Start is called before the first frame update
	void Start()
	{
		timer = timeSpawn;
	}

	// Update is called once per frame
	void Update()
	{
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			timer = timeSpawn;
			Spawn();
		}
	}
	void Spawn()
	{
		randX = Random.Range(-85f, 90f);
		randY = Random.Range(-30f, 30f);
		randZ = Random.Range(150f, 200f);
		whereToSpawn = new Vector3(randX, randY, randZ);
		int random = Random.Range(0, planetPrefab.Length-1);
		if (countPlanet < maxPlanet)
		{
			Instantiate(planetPrefab[random], whereToSpawn, Quaternion.identity);
			countPlanet++;
		}
		
	}
}
