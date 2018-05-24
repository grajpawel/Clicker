using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ms_soundOnOff : MonoBehaviour {
	public static float alpha;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (settings.settingsOn == true) {
			if (AudioListener.volume == 0) {
				transform.position = new Vector2 (6.7f, 4.2f);
				if (tmp.a >= 1) {
					tmp.a = 1;
				}
				tmp.a += GameController.appearSpeed;
			} else {
				tmp.a -= GameController.appearSpeed;
				if (tmp.a <= 0) {
					tmp.a = 0;
				}
				if (top_bg.alpha >= 1) {
					transform.position = new Vector2 (67f, 4.2f);
				}
			}
		} else {
			tmp.a -= GameController.appearSpeed;
			if (tmp.a <= 0) {
				tmp.a = 0;
			}
			if (top_bg.alpha >= 1) {
				transform.position = new Vector2 (67f, 4.2f);
			}
		}
	


		GetComponent<SpriteRenderer> ().color = tmp;
}
}
