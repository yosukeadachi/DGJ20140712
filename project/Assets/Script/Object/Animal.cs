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

			//
			LookAt2D(transform, mTarget, Vector2.up);

			//cola destroy
			coll.gameObject.SetActive(false);
		}
		else if(coll.gameObject.name.StartsWith ("exit")) {
			gameObject.SetActive(false);
		}
		//
	}

	/// <summary>
	/// 指定のオブジェクトの方向に回転する
	/// </summary>
	/// <param name="self">Self.</param>
	/// <param name="target">Target.</param>
	/// <param name="forward">正面方向</param>
	public static void LookAt2D(Transform self, Transform target, Vector2 forward)
	{
		LookAt2D (self, target.position, forward);
	}
	
	public static void LookAt2D(Transform self, Vector3 target, Vector2 forward)
	{
		var forwardDiff = GetForwardDiffPoint (forward);
		Vector3 direction = target - self.position;
		float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
		self.rotation = Quaternion.AngleAxis(angle - forwardDiff, Vector3.forward);
	}
	
	/// <summary>
	/// 正面の方向の差分を算出する
	/// </summary>
	/// <returns>The forward diff point.</returns>
	/// <param name="forward">Forward.</param>
	static private float GetForwardDiffPoint(Vector2 forward)
	{
		if (Equals (forward, Vector2.up)) return 90;
		if (Equals (forward, Vector2.right)) return 0;
		return 0;
	}
}
