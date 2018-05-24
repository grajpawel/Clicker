using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class mpRepeat : MonoBehaviour {
	public static bool repeat;
	private float timer;
	public static bool zeroScore;
	// Use this for initialization
	void Start () {
		repeat = false;

		transform.position = new Vector2 (100, 0);
	}

	// Update is called once per frame
	void Update () {
		//if (repeat == true)
			//Debug.Log (gameObject.name + "true");
		Color tmp = GetComponent<Image> ().color;

		if (GameController.scene == 4) {
			if (mp_red.hasPressed == true){
				transform.position = new Vector2 (0, 0);
				tmp.a += 0.015f;
				if (tmp.a >= 1) {
					tmp.a = 1;
				}
			} else {
				if (top_bg.alpha >= 1) {
					tmp.a = 0;
					transform.position = new Vector2 (100, 0);
				}
			}
		} else {
			if (top_bg.alpha >= 1) {
				tmp.a = 0;
				transform.position = new Vector2 (100, 0);
			}
		}

		if (GameController.scene == 1) {
			if (top_bg.alpha >= 0.99) {
				if (repeat == true) {
					GameController.scene = 4;
					repeat = false;
				}
			}
		}
		GetComponent<Image> ().color = tmp;
	}


	public void OnTap(){
		AudioCenter.playSound (GameController.soundId);
		zeroScore = false;
		GameController.scene = 1;
		top_bg.blackout = true;
		repeat = true;
		}
}
