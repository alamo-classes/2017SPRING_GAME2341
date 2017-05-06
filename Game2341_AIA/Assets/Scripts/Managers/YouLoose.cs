using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//T. Womack 9-2016, 4-2017
public class YouLoose : MonoBehaviour {
    public int loseScene;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(loseScene);
        }
    }
}
