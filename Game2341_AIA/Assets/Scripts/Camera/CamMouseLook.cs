using UnityEngine;
using System.Collections;

public class CamMouseLook : MonoBehaviour
{
    private Vector2 mouseLook;
    private Vector2 smoothV;

    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;
    public GameObject player;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        var mDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mDelta = Vector2.Scale(mDelta, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, mDelta.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, mDelta.y, 1f / smoothing);
        mouseLook += smoothV;

       // mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);
    }
}
