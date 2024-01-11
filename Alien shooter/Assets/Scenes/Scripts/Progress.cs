using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
[System.Serializable]

public class PlayerInfo
{
	public int Planets = 0;
    public int maxPlanets = 5;
}
public class Progress : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI countPlanet;
	public PlayerInfo PlayerInfo;
	public static Progress Instance;
	private void Awake()
	{
		if (Instance == null)
		{
			transform.parent = null;
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		countPlanet.text = Instance.PlayerInfo.Planets.ToString() + "/" + Instance.PlayerInfo.maxPlanets.ToString();
	}
}
