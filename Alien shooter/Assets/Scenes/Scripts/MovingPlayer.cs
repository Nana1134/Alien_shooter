using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
	private Rigidbody rb;

	public float rotationSpeed = 0.5f;
	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
		float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
		transform.localEulerAngles = new Vector3(0, rotationX, 0);
	}
}
