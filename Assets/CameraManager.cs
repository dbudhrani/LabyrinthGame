using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	public Camera camera4;

	// Use this for initialization
	void Start () {
		camera1.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;
		camera4.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			camera1.enabled = true;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled = false;
		}
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			camera2.enabled = true;
			camera1.enabled = false;
			camera3.enabled = false;
			camera4.enabled = false;
		}
		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			camera3.enabled = true;
			camera1.enabled = false;
			camera2.enabled = false;
			camera4.enabled = false;
		}
		if (Input.GetKeyDown(KeyCode.Alpha4)) {
			camera4.enabled = true;
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
		}
	}
}
