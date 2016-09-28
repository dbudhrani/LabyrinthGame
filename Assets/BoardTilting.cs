using UnityEngine;
using System.Collections;

public class BoardTilting : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Rotate(Vector3.right, 10 * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate(Vector3.back, 10 * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Rotate(Vector3.left, 10 * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Rotate(Vector3.forward, 10 * Time.deltaTime);

		}
	}
}
