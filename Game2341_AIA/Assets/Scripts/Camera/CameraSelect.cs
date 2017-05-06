using UnityEngine;
using System.Collections;

//T. Womack 9-2016, 4-2017
public class CameraSelect : MonoBehaviour
{

    public Camera camera1;
    public Camera camera2;
    public Camera camera3;

	// Use this for initialization
	void Start () {
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
	}
	//Main player POV camera
    public void selectCam1()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
    }
	//Local map view (lower right of screen
    public void selectCam2()
    {
        camera1.enabled = true;
        camera2.enabled = true;
        camera3.enabled = false;
    }
	//Full screen map view.
    public void selectCam3()
    {
        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = true;
    }
}