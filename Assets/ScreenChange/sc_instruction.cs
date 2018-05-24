using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_instruction : MonoBehaviour {
	public static bool isVisible;
	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (50, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.scene == 1) 
			isVisible = true;
		
		if (top_bg.alpha >= 1) {
			if (GameController.scene == 3) {
				if (isVisible == true) {
					transform.position = new Vector2 (0, 0);
				} else {
					transform.position = new Vector2 (50, 0);
				}
				
			} else {
				transform.position = new Vector2 (50, 0);

			}
		}
		if (SC_bg.alpha >= 1)
			transform.position = new Vector2 (50, 0);
	
}
}
