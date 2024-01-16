using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]

public class PlayerInfo
{
	public int Planets = 0;
    public int maxPlanets = 5;
	public GameObject panelWin;
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
			//DontDestroyOnLoad(gameObject);
			Instance = this;
		}
		//else
		//{
		//	Destroy(gameObject);
		//}
	}
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		countPlanet.text = Instance.PlayerInfo.Planets.ToString() + "/" + Instance.PlayerInfo.maxPlanets.ToString();
		if (Instance.PlayerInfo.Planets == Instance.PlayerInfo.maxPlanets)
		{
			Time.timeScale = 0;
			Win();
		}
	}
	private void Win()
	{
		Instance.PlayerInfo.panelWin.SetActive(true);
		if (SceneManager.GetActiveScene().buildIndex - 1 == LVLManager.countUnlockedLevel ) 
		{
			LVLManager.countUnlockedLevel++;
		}
	}
}
