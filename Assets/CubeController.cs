using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		//課題追加分
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		// キューブを移動させる
		transform.Translate(this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy(gameObject);
		}
	}
	//衝突時に呼ばれる関数
    void OnCollisionEnter2D(Collision2D other){
		if(other.transform.tag == "Cube"){
			audioSource.Play();
		}

    }
}
