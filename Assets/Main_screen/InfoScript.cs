using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour {
	public Text info;
	// Use this for initialization
	void Start () {
		info = GetComponent<Text> ();
		info.fontSize = Screen.width / 15;
	}
	
	// Update is called once per frame
	void Update () {
		
			if (top_bg.alpha >= 1) {
			if (GameController.scene == 6){
				transform.position = Vector2.zero;
			} else {
				transform.position = new Vector2 (100, 0);
	}
}
	}
}
