using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	public int[] score = new int[] {0, 0, 0, 0};
	// Use this for initialization
	
	public void addscore(int id){
		score[id]++;
	}

	public int getscore(int id){
		return score[id];
	}
}
