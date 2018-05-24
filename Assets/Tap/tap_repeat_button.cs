using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap_repeat_button : MonoBehaviour {
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
		if (GameController.scene == 2) {
			if (tap_red.hasPressed == true) {
				transform.position = new Vector2 (8.1f, 4.2f);
			} else {
				if (top_bg.alpha >= 1) {
					transform.position = new Vector2 (100, 0);
				}
			}
		} else {
			if (top_bg.alpha >= 1) {
				transform.position = new Vector2 (100, 0);
			}
		}

		if (GameController.scene == 1) {
			if (top_bg.alpha >= 0.99) {
				if (repeat == true) {
					GameController.scene = 2;
					repeat = false;
				}
			}
		}
	}


	public void OnTap(){
		AudioCenter.playSound (GameController.soundId);
		tap_instruction.isVisible = true;
		GameController.scene = 1;
		top_bg.blackout = true;
		repeat = true;
	}
}
