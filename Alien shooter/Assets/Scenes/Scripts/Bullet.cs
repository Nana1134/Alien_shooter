using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float bulletlife = 3;
	private void Start()
	{
		
	}

	private void Awake()
	{
		Destroy(gameObject, bulletlife);
	}

	private void OnCollisionEnter(Collision collision)
	{

		Destroy(collision.gameObject);
		Destroy(gameObject);
	}
	

}
