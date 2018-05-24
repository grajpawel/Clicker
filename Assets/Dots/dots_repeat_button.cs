using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dots_repeat_button : MonoBehaviour {
	public static bool repeat;
	private float timer;
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

		if (GameController.scene == 5) {
			if (dotsController.gameOn == false){
				transform.position = new Vector2 (8.1f, 4.2f);
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
					GameController.scene = 5;
					repeat = false;
				}
			}
		}
		GetComponent<Image> ().color = tmp;
	}


	public void OnTap(){
		AudioCenter.playSound (GameController.soundId);
		tap_instruction.isVisible = true;
		GameController.scene = 1;
		top_bg.blackout = true;
		repeat = true;
	}
}
