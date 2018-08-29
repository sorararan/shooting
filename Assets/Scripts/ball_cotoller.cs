using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_cotoller : MonoBehaviour {
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		// 完全に止まってるボールをなくす
		if(rb.velocity == Vector3.zero){
			rb.velocity = new Vector3(Random.Range(-1.0f, 1.0f),Random.Range(-1.0f, 1.0f),Random.Range(-1.0f, 1.0f));
		}

		// 真ん中の四角いゾーンにいる間は速度を上げる
		if(Mathf.Abs(this.transform.localPosition.x) < 38.8f && Mathf.Abs(this.transform.localPosition.z) < 38.8f){
			rb.velocity *= 1.02f;
		}
	}
}
