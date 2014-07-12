using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D()
	{
		GameRuleManager _manager = (GameRuleManager)GameObject.Find("_GameRuleManager").GetComponent("GameRuleManager");
		_manager.gameOver();
		//
	}
	void OnTriggerEnter2D()
	{
		GameRuleManager _manager = (GameRuleManager)GameObject.Find("_GameRuleManager").GetComponent("GameRuleManager");
		_manager.gameOver();
		//
	}
}
