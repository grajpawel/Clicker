using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit_mp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (100, 100);
	}


	// Update is called once per frame
	void Update () {
		if (GameController.scene != 1) {
			if (Input.GetKeyDown (KeyCode.Escape))
				OnTap ();
		}
		if (top_bg.alpha >= 1) {
			if (GameController.scene == 4) {

				transform.position = new Vector2 (8.1f, -4.2f);

			} else {
				transform.position = new Vector2 (50, 0);
			}
		}
	}
	public void OnTap(){
		AudioCenter.playSound (GameController.soundId);
		mpRepeat.zeroScore = true;
		top_bg.blackout = true;

		GameController.scene = 1;
	}
}
