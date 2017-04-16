using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ShowMouse : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
	}
    
    void OnLevelWasLoaded(int level)
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }	
}
