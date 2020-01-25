using System.Collections;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {
    GameObject unitychan;

    float distance;

    void Start () {
        unitychan = GameObject.Find("unitychan");

        //unitychanとの距離を計算
        distance = unitychan.transform.position.z - transform.position.z;
    }
	
	void Update () {
        //unitychanを一定距離を保って追尾
        transform.position = new Vector3(0, transform.position.y, unitychan.transform.position.z - distance);
	}

    //衝突したオブジェクトを破棄
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
