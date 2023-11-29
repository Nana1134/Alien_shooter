using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public GameObject BulletPrefab;
	public Camera mainCamera;
	public Transform spawnBullet;
	[SerializeField] TextMeshProUGUI textSnake;

	public float BulletVelocity = 180f;
	public int countShoot = 0;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			Shoot();
			countShoot++;
		}
	}
	private void Shoot()
	{
		// Реализация стрельбы через рейкаст
		Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
		RaycastHit hit;

		Vector3 targetPoint;
		if (Physics.Raycast(ray, out hit)) 
			targetPoint = hit.point;
		else targetPoint = ray.GetPoint(75);

		Vector3 dirWithoutSpread = targetPoint - spawnBullet.position;

		GameObject newBullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
		
		newBullet.transform.forward = dirWithoutSpread.normalized;
		newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletVelocity;
	
	}
}
