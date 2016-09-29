using UnityEngine;
using System.Collections;

public class BlackHoleCollision : MonoBehaviour {

	public Vector3 startPosition = new Vector3(6f, 6f, 1.75f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Earth") {
			col.gameObject.transform.position = Vector3.Lerp(transform.position, startPosition, 1.0f);
		}
	}
}
