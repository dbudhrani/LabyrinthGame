using UnityEngine;
using System.Collections;

public class CoinCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
    {
    	Debug.Log("Collider = " + col.gameObject.name);
        if(col.gameObject.name == "ball")
        {
        	Debug.Log("Ball collided");
            Destroy(gameObject);
        }
    }

}
