using UnityEngine;
using System.Collections;

public class FireWall : MonoBehaviour {

	float wallVelocity = 0.0f;//1.2f

	const float wallDownLimit = -1.2f;
	const float wallDown = 0.1f;
	const float wallUP = 1.5f;

	// Use this for initialization
	void Start () {
	//	rigidbody2D.AddForce(Vector2.right * 300f);
	}
	
	// Update is called once per frame
	void Update () {
		if(wallVelocity > wallDownLimit)
		{
			wallVelocity -= wallDown;
		}

		rigidbody2D.velocity = Vector2.up * wallVelocity;
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		Debug.Log ("FireWall coll:" + coll.gameObject.name + " class:" + coll.GetType().FullName);
		if(coll.gameObject.name.StartsWith ("cola_tsubu")) {

			wallVelocity = wallUP;
			
			//cola destroy
			coll.gameObject.SetActive(false);
		}
	}
}
