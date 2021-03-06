﻿/*
 * @file;
 * @brief	ゲームシーン タイトル;
 * @auther	Yosuke Adachi;
 * @data	2014-07-01;
 */
/*------------------------------------------------------------
/ Using
/------------------------------------------------------------*/
using UnityEngine;
using System.Collections;

/*------------------------------------------------------------
/ タイトル ;
/------------------------------------------------------------*/
public class TitleMainGameScene : GameScene {
	/*
	 * シーン内オブジェクト;
	 */
	public ObjectManager.eGameObjects[] mList = {
		ObjectManager.eGameObjects.TOUCH_TO_START,
		ObjectManager.eGameObjects.TITLE_BG,
	};

	/*
	 * 初期化;
	 */
	public override void init(){
		Debug.Log("to Scene title");
		initObjects (mList);
	}

	/*
	 * 更新;
	 */
	public override void update(){
		if (InputManager.isTouchObject("taitle(Clone)")) {
			SceneController.setChangeScene(SceneController.Scene.GAME_MAIN);
		}
	}
	
	/*
	 * GUI更新;
	 */
	public override void onGui(){
	}
}