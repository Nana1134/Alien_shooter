using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

	}
	public void Next()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}

	public void Menu()
    {
		SceneManager.LoadScene("LVL_Select");
	}
}
