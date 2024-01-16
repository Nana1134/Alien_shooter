using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlanetController : MonoBehaviour
{
	
	[SerializeField] Vector3 rotation;
	[SerializeField] Transform meshObject = null;
	[SerializeField] float rotationSpeed = 0;
	[SerializeField] bool randomize;
	// стартовая позиция
	private Vector3 startPosition;
	// конечная позиция объекта
	private Vector3 finalPoint;

	public bool Randomize

	{
		get
		{
			return randomize;
		}
	}

	float RandFloat()

	{
		return Random.Range(0f, 1.01f);
	}

	[SerializeField] float maxRotationSpeed;
	[SerializeField] float minRotationSpeed;

	// Start is called before the first frame update
	void Start()
    {
		
		startPosition = transform.position;
		if (meshObject == null)

		{
			meshObject = transform.Find("planet");
			if (meshObject == null)
				meshObject = transform.Find("w2");
		}


		if (randomize)

		{
			rotation = new Vector3(RandFloat(), RandFloat(), RandFloat());
			rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
		}
	}

	// Update is called once per frame
	void Update()
    {
		finalPoint = new Vector3(4.5f,-3.5f,-5f);
		transform.position = Vector3.Lerp(transform.position, finalPoint, 0.8f * Time.deltaTime);
		
	}

	void FixedUpdate()

	{
		if (meshObject != null)
			meshObject.Rotate(rotation, rotationSpeed * Time.deltaTime);
	}

	private void OnCollisionEnter(Collision collision)
	{
		AddScore();
	}


	private void AddScore()
	{
		Progress.Instance.PlayerInfo.Planets += 1;
	}
}
