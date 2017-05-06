using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//T. Womack 9-2016, 4-2017
public class LoadOnClick : MonoBehaviour
{

	//public GameObject loadingImage;

	public void LoadScene(int level)
	{
		//loadingImage.SetActive(true);
		SceneManager.LoadScene(level);
	}
}
