using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletlife = 3;

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
