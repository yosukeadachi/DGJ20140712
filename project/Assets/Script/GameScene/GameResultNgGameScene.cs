﻿/*
 * @file;
 * @brief	ゲームシーン 結果NG;
 * @auther	Yosuke Adachi;
 * @data	2014-07-01;
 */
/*------------------------------------------------------------
/ Using
/------------------------------------------------------------*/
using UnityEngine;
using System.Collections;
using System;

/*------------------------------------------------------------
/ 結果NG;
/------------------------------------------------------------*/
public class GameResultNgGameScene : GameScene {
	/*
	 * シーン内オブジェクト;
	 */
	public ObjectManager.eGameObjects[] mList = {
		ObjectManager.eGameObjects.GAMEOVER,
	};

	/*
	 * 初期化;
	 */
	public override void init(){
		Debug.Log("to Scene result ng");
		initObjects (mList);
	}

	/*
	 * 更新;
	 */
	public override void update(){
		if (InputManager.isTouchObject("Game_Over 1(Clone)")) {
			SceneController.setChangeScene(SceneController.Scene.TITLE_MAIN);
		}
	}
	
	/*
	 * GUI更新;
	 */
	public override void onGui(){
	}
}