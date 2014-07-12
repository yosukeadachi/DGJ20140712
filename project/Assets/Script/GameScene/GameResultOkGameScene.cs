/*
 * @file;
 * @brief	ゲームシーン 結果OK;
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
/ 結果OK;
/------------------------------------------------------------*/
public class GameResultOkGameScene : GameScene {
	/*
	 * シーン内オブジェクト;
	 */
	public ObjectManager.eGameObjects[] mList = {
	};

	/*
	 * 初期化;
	 */
	public override void init(){
		Debug.Log("to Scene result ok");
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