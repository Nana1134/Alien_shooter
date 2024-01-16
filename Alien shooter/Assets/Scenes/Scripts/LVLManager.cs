using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LVLManager : MonoBehaviour
{
    public static int countUnlockedLevel = 1;
	// Start is called before the first frame update
	void Start()
    {
     for (int i = 0; i < transform.childCount; i++)
        {
            if(i < countUnlockedLevel)
            {
                transform.GetChild(i).GetComponent<Button>().interactable = true;
            }
            else
            {
				transform.GetChild(i).GetComponent<Button>().interactable = false;

			}
		} 
    }
	public void PlayScene(int numlvl)
	{
		SceneManager.LoadScene(numlvl);
	}
}
