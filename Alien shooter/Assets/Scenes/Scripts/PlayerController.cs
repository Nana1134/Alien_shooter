using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	private Rigidbody rb;
	public float rotationSpeed = 300f;
	private float hp = 1f;
	public Scrollbar scrollbar;
	public GameObject panelFail;
	void Start()
    {
		Time.timeScale = 1;
		rb = GetComponent<Rigidbody>();
		transform.rotation = new Quaternion(0,0,0,0) ;
	}
		
    void Update()
    {
		float rotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
		float rotationX = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
		transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
		if (hp <= 0f)
		{
			Time.timeScale = 0;
			panelFail.SetActive(true);
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Planet")
		{
			hp -= 0.34f;
			scrollbar.size = hp;
			Destroy(other.gameObject);
		}
	}
}
