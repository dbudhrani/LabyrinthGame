using UnityEngine;
using System.Collections;

public class MarsCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Earth") {
			Debug.Log("You reached Mars. You win!");
			Destroy(gameObject);
		} 
	}
}
