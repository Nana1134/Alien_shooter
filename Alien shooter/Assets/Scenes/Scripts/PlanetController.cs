using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlanetController : MonoBehaviour
{
	// ��������� �������
	private Vector3 startPosition;
	// �������� ������� �������
	private Vector3 finalPoint;

	// Start is called before the first frame update
	void Start()
    {
		startPosition = transform.position;
	}

	// Update is called once per frame
	void Update()
    {
		finalPoint = new Vector3(4.5f,-3.5f,-5f);
		transform.position = Vector3.Lerp(transform.position, finalPoint, 0.5f * Time.deltaTime);
	}
}
