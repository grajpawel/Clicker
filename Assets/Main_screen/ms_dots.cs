using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ms_dots : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (top_bg.alpha >= 1) {
			if (GameController.scene == 1) {
				transform.position = new Vector2 (1.5f, -1.5f);
			} else {
				transform.position = new Vector2 (-150, -15);
			}
		}
	}
	public void OnTap(){
		AudioCenter.playSound (GameController.soundId);
		top_bg.blackout = true;
		GameController.scene = 5;
	}
}
