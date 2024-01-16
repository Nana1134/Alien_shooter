using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class SpawnPlanet : MonoBehaviour
{
	public GameObject[] planetPrefab;

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
		Instantiate(planetPrefab[random], whereToSpawn, Quaternion.identity);
	}
	
}
