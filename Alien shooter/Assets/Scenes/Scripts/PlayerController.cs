using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody rb;
	public float rotationSpeed = 300f;
	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();
		transform.rotation = new Quaternion(0,0,0,0) ;
	}

	
    // Update is called once per frame
    void Update()
    {
		float rotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
		float rotationX = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
		transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
	}
}
