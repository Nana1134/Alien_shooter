using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
	public GameObject BulletPrefab;
	public Camera mainCamera;
	public Transform spawnBullet;
	[SerializeField] TextMeshProUGUI counter;

	public float BulletVelocity = 180f;
	public int maxShoot = 5;
	public int countShoot = 0;

	public int cor_delay = 3;
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
			CountShoots();

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
	private void CountShoots()
	{		
		countShoot++;
		counter.text = countShoot.ToString() + "/" + maxShoot.ToString();
		if (countShoot == maxShoot)
		{
			StartCoroutine(DelayCore()); 
		}
	}

	public void OpenMenu()
	{
		SceneManager.LoadScene("Menu");
	}


	IEnumerator DelayCore() 
	{
		yield return new WaitForSeconds(cor_delay);
		Console.WriteLine("DELAY");
		OpenMenu(); // Сделать canva с поражением кнопками главного меню, restart уровень

	}

}
