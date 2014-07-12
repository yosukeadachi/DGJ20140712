/*
 * @file;
 * @brief	ゲームシーン ゲームメイン;
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
/ ゲームメイン;
/------------------------------------------------------------*/
public class GameMainGameScene : GameScene {

	/*
	 * シーン内オブジェクト;
	 */
	public ObjectManager.eGameObjects[] mList = {
		ObjectManager.eGameObjects.USAGI,
		ObjectManager.eGameObjects.EXIT,
		ObjectManager.eGameObjects.FIREWALL,
	};

	/*
	 * 初期化;
	 */
	public override void init(){
		Debug.Log("to Scene main");
		initObjects (mList);
	}

	/*
	 * 更新;
	 */
	public override void update(){
	}

	/*
	 * GUI更新;
	 */
	public override void onGui(){
	}


}