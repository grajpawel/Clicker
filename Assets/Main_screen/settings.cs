using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settings : MonoBehaviour {
	public static bool settingsOn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (top_bg.alpha >= 1) {
			if (GameController.scene == 1) {
				transform.position = new Vector2 (8.1f, 4.2f);
			} else {
				settingsOn = false;
				transform.position = new Vector2 (-150, -15);
			}
		}
	}
	public void OnTap(){
		AudioCenter.playSound (GameController.soundId);
		if (settingsOn == true){
			settingsOn = false;
		} else {
			settingsOn = true;
		}
	}
}

