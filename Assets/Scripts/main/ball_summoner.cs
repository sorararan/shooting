using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_summoner : MonoBehaviour {

	int ball_num = 100;
	GameObject ballPrefab;

	// Use this for initialization
	void Start () {
		ballPrefab = (GameObject) Resources.Load ("Prefabs/ball");
		// ボールを真ん中の四角いゾーンの上に生成
		for (int i = 0; i < ball_num; i++) {
			Instantiate (
				ballPrefab,
				new Vector3 (Random.Range (-30.0f, 30.0f), 40.0f, Random.Range (-30.0f, 30.0f)),
				Quaternion.identity
			);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}