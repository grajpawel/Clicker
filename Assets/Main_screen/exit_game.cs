using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_game : MonoBehaviour {
	private bool quit = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (top_bg.blackout == false){
			if (Input.GetKeyDown (KeyCode.Escape))
				OnTap ();
		}
		if (top_bg.alpha >= 1) {
			if (quit == true) {
				Application.Quit ();
			}
		
			if (GameController.scene == 1) {
				transform.position = new Vector2 (-8.1f, 4.2f);
			} else {
				transform.position = new Vector2 (-150, -15);
			}
		}
	}
	public void OnTap(){
		AudioCenter.playSound (GameController.soundId);
		top_bg.blackout = true;
		quit = true;

}
}
