using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

	public int mCount = 0;
	public Transform mTarget;
	// Use this for initialization
	void Start () {
		mCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(mCount > 0) {
			mCount--;
			if(mCount == 0)
			{
				rigidbody2D.velocity = Vector3.zero;
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D coll)
	{
		Debug.Log ("Animal coll:" + coll.gameObject.name + " class:" + coll.GetType().FullName);
		if(coll.gameObject.name.CompareTo("firewall(Clone)") == 0) {
			GameRuleManager _manager = (GameRuleManager)GameObject.Find("_GameRuleManager(Clone)").GetComponent("GameRuleManager");
			_manager.gameOver();
		}
		else if(coll.gameObject.name.StartsWith ("cola_tsubu")) {
			//cola mituketa!
			mCount = 50;
			mTarget = coll.transform;
			Vector2 heading = mTarget.position - gameObject.transform.position;
			float distance = heading.magnitude;
			float force = 0.75f;
			Vector2 direction = heading / distance * force;
			rigidbody2D.velocity = direction;

			//cola destroy
			coll.gameObject.SetActive(false);
		}
		else if(coll.gameObject.name.StartsWith ("exit")) {
			gameObject.SetActive(false);
		}
		//
	}
}
