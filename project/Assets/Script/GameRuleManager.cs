using UnityEngine;
using System.Collections;

public class GameRuleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/**
	 * ;
	 */
	public void gameOver() {
		SceneController.setChangeScene(SceneController.Scene.GAME_RESULT_NG);
	}
}
