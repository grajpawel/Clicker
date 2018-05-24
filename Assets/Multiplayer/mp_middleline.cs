using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mp_middleline : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (GameController.scene == 1) {
			if (top_bg.alpha >= 0.95) {
				
				transform.position = new Vector2 (100, 0);
				tmp.a = 1;
			}
		}
		if (GameController.scene == 4){
			if (top_bg.alpha >= 1){
				transform.position = new Vector2 (0, 0);
	}
			if (mp_red.hasPressed == true){
				tmp.a -= 0.015f;
}
	}
		GetComponent<SpriteRenderer> ().color = tmp;
}
}
