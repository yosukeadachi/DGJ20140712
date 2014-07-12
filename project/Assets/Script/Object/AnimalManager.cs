using UnityEngine;
using System.Collections;

public class AnimalManager : MonoBehaviour {

	// ;
	public enum eAnimalObjects : int
	{
		USAGI = 0,
	}

	public GameObject[] mGameObjectListBase;
	public static GameObject[] mGameObjectListTemp;
	private static GameObject[] mStageObjects;				//  stageごとのオブジェクト情報;
	
	// Use this for initialization
	void Start () {
		mGameObjectListTemp = mGameObjectListBase;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/**
	 * @brief オブジェクト初期設定;
	 * @note
	 */
	public static void initObjects(eAnimalObjects[] aList) {
		// オブジェクト破棄;
		destroyStageObjectsAll ();
		// オブジェクト生成;
		makeGameObjectsInScene (aList);
	}


	/**
	 * @brief	stage内のゲームオブジェクトをすべて破棄;
	 * @note
	 */
	public static void destroyStageObjectsAll()
	{
		if (mStageObjects == null) {
			return;
		}
		foreach (GameObject _object in mStageObjects) {
			Destroy(_object);
		}
	}

	/**
	 * @brief	シーン内のゲームオブジェクト領域の確保;
	 * @param	aNumber		シーン内のオブジェクトの総数;
	 * @note
	 */
	public static void allocateSceneObjects(int aNumber) {
		mStageObjects = new GameObject[aNumber];
	}
	
	/**
	 * @brief	ゲームオブジェクト生成;
	 * @param	aListIndex		オブジェクトリスト内のインデックス;
	 * @return	ゲームオブジェクト;
	 * @note
	 */
	public static GameObject createGameObject(eAnimalObjects aListIndex) {
		return (GameObject)Instantiate(mGameObjectListTemp[(int)aListIndex]);
	}
	
	/**
	 * @brief	指定したシーンリストのオブジェクトを作成;
	 * @pram	aList		シーン内のゲームオブジェクト番号リスト
	 * @note
	 */
	public static void makeGameObjectsInScene(eAnimalObjects[] aList) {
		allocateSceneObjects (aList.Length);
		for(int i = 0; i < aList.Length; i++) {
			mStageObjects[i] = createGameObject(aList[i]);
		}
	}

	/**
	 * 
	 */
	public static int getActiveCount() {
		int _count = 0;
		foreach(GameObject _obj in mStageObjects ) {
			if(_obj.activeSelf) {
				_count++;
			}
		}
		return _count;
	}
}
