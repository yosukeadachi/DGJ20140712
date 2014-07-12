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

	private int mTsubuIndex;	// okeru tsubu;
	private int TSUBU_LIMIT = 10;
	private int COLA_LEFT_LIMIT = 9;
	private int mColaLeft;// ko-ra zanryo;

	/*
	 * シーン内オブジェクト;
	 */
	public ObjectManager.eGameObjects[] mList = {
		ObjectManager.eGameObjects.ANIMAL_MANAGER,
		ObjectManager.eGameObjects.EXIT,
		ObjectManager.eGameObjects.FIREWALL,
		ObjectManager.eGameObjects.FOOD_DROP,
		ObjectManager.eGameObjects.ROAD_TILE,
		ObjectManager.eGameObjects.GAME_RULE_MANAGER,
		ObjectManager.eGameObjects.COKE_RIVER,
		ObjectManager.eGameObjects.COLA_MANAGER,
	};

	public AnimalManager.eAnimalObjects[] mAnimalList = {
		AnimalManager.eAnimalObjects.USAGI,
	};

	/*
	 * 初期化;
	 */
	public override void init(){
		Debug.Log("to Scene main");
		initObjects (mList);
		mTsubuIndex = 0;
		mColaLeft = COLA_LEFT_LIMIT;// ko-ra zanryo;
		
		AnimalManager.initObjects(mAnimalList);
	}

	/*
	 * 更新;
	 */
	public override void update(){
		if (InputManager.isTouchObject("road_tile(Clone)")) {
			Debug.Log ("cola!");
			if(mColaLeft > 0) {
				GameObject _counter = GameObject.Find ("_ColaManager(Clone)");
				_counter.transform.FindChild ("coke_" + (mColaLeft)).gameObject.SetActive(false);

				mColaLeft--;
				GameObject _tsubu = GameObject.Find ("cola_tsubu_manager(Clone)").transform.FindChild("cola_tsubu_" + mTsubuIndex).gameObject;
				Vector3 vec = Input.mousePosition;
				vec.z = 10f;
				_tsubu.transform.position = Camera.main.ScreenToWorldPoint(vec);
				_tsubu.SetActive(true);
				mTsubuIndex++;
				if(mTsubuIndex == TSUBU_LIMIT) {
					mTsubuIndex = 0;
				}

			}
		}
	}

	/*
	 * GUI更新;
	 */
	public override void onGui(){
	}


}