using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D coll)
	{
		Debug.Log ("Animal coll:" + coll.gameObject.name);
		Debug.Log ("cola_tsubu:" + (coll.gameObject.name.StartsWith ("cola_tsubu")));
		if(coll.gameObject.name.CompareTo("firewall(Clone)") == 0) {
			GameRuleManager _manager = (GameRuleManager)GameObject.Find("_GameRuleManager").GetComponent("GameRuleManager");
			_manager.gameOver();
		}
		else if(coll.gameObject.name.StartsWith ("cola_tsubu")) {

			rigidbody2D.velocity = new Vector2(1.0f, -1.0f);
		}
		else if(coll.gameObject.name.StartsWith ("exit")) {
			gameObject.SetActive(false);
		}
		//
	}
}
