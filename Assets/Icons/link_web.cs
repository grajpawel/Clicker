using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class link_web: MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<Image> ().color;
		if (settings.settingsOn == true) {
			transform.position = new Vector2 (8.1f, 0);
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





		GetComponent<Image> ().color = tmp;
	}
	public void OnTap (){
		AudioCenter.playSound (GameController.soundId);
		Application.OpenURL("https://papl0.wordpress.com/");
	}
}

