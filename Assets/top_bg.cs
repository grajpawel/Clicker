using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class top_bg : MonoBehaviour {
	public static float alpha;
	public static bool blackout = false;
	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (0, 0);
	}
	
	// Update is called once per frame
	void Update () {

		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (GameController.scene == 10) {
			tmp.a += 0.015f;
			if (tmp.a >= 1) {
				SceneManager.LoadScene ("Clicker");
			}
		}
		if (blackout == false) {
			tmp.a -= 0.015f;
			if (tmp.a <= 0){
				tmp.a = 0;
			}
		} else {
			tmp.a += 0.015f;
			if (alpha >= 1){
				blackout = false;
		}
		}
	
		GetComponent<SpriteRenderer> ().color = tmp;
		alpha = tmp.a;

	}
}

