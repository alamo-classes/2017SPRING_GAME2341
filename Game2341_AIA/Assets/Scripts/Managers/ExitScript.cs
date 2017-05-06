using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//T. Womack 9-2016, 4-2017
public class ExitScript : MonoBehaviour
{
	void Start()
	{
	}

	public void quit()
	{
		//Debug.Log("Exit");
		Application.Quit();
	}

	public void LostScene(string level)
	{
		//Debug.Log (level);
		SceneManager.LoadScene(level);
	}
}
