using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipper_controller : MonoBehaviour {
	//プレイヤーid
	[SerializeField]
	int id;
	// フリッパーのleft(0)かright(1)か
	[SerializeField]
	int lr;

	// 左、右のフリッパーの行く元fromと行き先to、0が左、1が右
	Quaternion[] to = new Quaternion[] {
		//フリッパー 左、右 
		Quaternion.Euler (0, -60, 0), Quaternion.Euler (0, 60, 0)
	};

	Quaternion[] from = new Quaternion[] {
		// フリッパー 左、右
		Quaternion.Euler (0, 0, 0), Quaternion.Euler (0, 0, 0)
	};

	float t;
	float t_max = 1.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (this.id == 0) {
			if (Input.GetKey (KeyCode.A)) {
				if (t < t_max) {
					t += 3.0f * Time.deltaTime;
				}
				transform.rotation = Quaternion.Slerp (from[lr], to[lr], t);
			} else {
				if (t > 0) {
					t -= 3.0f * Time.deltaTime;
				}
				transform.rotation = Quaternion.Slerp (from[lr], to[lr], t);
			}
		} else if (this.id == 1) {
			if (Input.GetKey (KeyCode.S)) {
				if (t < t_max) {
					t += Time.deltaTime;
				}
				transform.rotation = Quaternion.Slerp (from[lr], to[lr], t);
			} else {
				if (t > 0) {
					t -= Time.deltaTime;
				}
				transform.rotation = Quaternion.Slerp (from[lr], to[lr], t);
			}
		} else if (this.id == 2) {
			if (Input.GetKey (KeyCode.D)) {
				if (t < t_max) {
					t += Time.deltaTime;
				}
				transform.rotation = Quaternion.Slerp (from[lr], to[lr], t);
			} else {
				if (t > 0) {
					t -= Time.deltaTime;
				}
				transform.rotation = Quaternion.Slerp (from[lr], to[lr], t);
			}
		} else {
			if (Input.GetKey (KeyCode.F)) {
				if (t < t_max) {
					t += Time.deltaTime;
				}
				transform.rotation = Quaternion.Slerp (from[lr], to[lr], t);
			} else {
				if (t > 0) {
					t -= Time.deltaTime;
				}
				transform.rotation = Quaternion.Slerp (from[lr], to[lr], t);
			}
		}
	}
}