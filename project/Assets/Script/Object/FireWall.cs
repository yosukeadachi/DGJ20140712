using UnityEngine;
using System.Collections;

public class FireWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	//	rigidbody2D.AddForce(Vector2.right * 300f);
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = Vector2.up * -0.3f;
	}
}
