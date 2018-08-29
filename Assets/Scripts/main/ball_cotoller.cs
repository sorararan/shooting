using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_cotoller : MonoBehaviour {
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Return)){
			ScoreManager scoremanager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
			if(transform.localPosition.x > 105f){
				scoremanager.addscore(0);
			}else if(transform.localPosition.x < -105f){
				scoremanager.addscore(1);
			}else if(transform.localPosition.z > 105f){
				scoremanager.addscore(2);
			}else if(transform.localPosition.z < -105f){
				scoremanager.addscore(3);
			}
			Destroy(this.gameObject);
		}

		// 完全に止まってるボールをなくす
		if (rb.velocity == Vector3.zero) {
			rb.velocity = new Vector3 (Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f));
		}

		if (transform.localPosition.y > 45) {
			rb.velocity = new Vector3 (rb.velocity.x, -40f, rb.velocity.z);
		}

		// 真ん中の四角いゾーンにいる間は速度を上げる
		if (Mathf.Abs (this.transform.localPosition.x) < 38.8f && Mathf.Abs (this.transform.localPosition.z) < 38.8f) {
			rb.AddForce(transform.forward);
		}
	}

	void OnCollisionEnter (Collision collision) {
		if (Mathf.Abs(transform.localPosition.x) < 105 && Mathf.Abs(transform.localPosition.z) < 105) {
			if (collision.gameObject.tag == "flipper") {
				rb.AddForce ((Vector3.zero - transform.localPosition) * collision.gameObject.GetComponent<flipper_controller> ().angularspeed * 1500);
			}
		}
	}
}