using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class you_lost : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (GameController.scene == 1) {
			if (top_bg.alpha >= 0.95) {
				tmp.a = 0;
			}
		}

		if (mp_red.hasPressed == true) {
			tmp.a += 0.015f;
			if (mp_red.winner == 1) {
				transform.position = new Vector2 (0, 2f);
				transform.localEulerAngles = new Vector3 (0, 0, 180);
			} else {
				transform.position = new Vector2 (0, -2);
				transform.localEulerAngles = new Vector3 (0, 0, 0);
			
		}
	}
		GetComponent<SpriteRenderer> ().color = tmp;
}
}
