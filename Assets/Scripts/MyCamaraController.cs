using System.Collections;
using UnityEngine;

public class MyCamaraController : MonoBehaviour {
    //Unityちゃんのオブジェクト
    GameObject unitychan;
    //Unityちゃんとカメラの位置
    float difference;

	void Start () {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとカメラの位置（ｚ座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
	}
	
	void Update () {
        //Unityちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
	}
}
