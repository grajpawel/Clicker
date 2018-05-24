using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ms_sound : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
		if (PlayerPrefs.HasKey ("Sound")) {
		}
		else {
			PlayerPrefs.SetInt("Sound", 1);

		}

	}
	
	// Update is called once per frame
	void Update () {
		
		Color tmp = GetComponent<Image> ().color;
		if (settings.settingsOn == true) {
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
	
	
				


		GetComponent<Image> ().color = tmp;
	
		if (PlayerPrefs.GetInt ("Sound") == 1) {
			AudioListener.volume = 1f;

		}
		if (PlayerPrefs.GetInt ("Sound") == 0) {
			AudioListener.volume = 0f;

		}

	} public void OnTap(){
		AudioCenter.playSound (GameController.soundId);
		
		if (PlayerPrefs.GetInt ("Sound") == 1) {
			PlayerPrefs.SetInt ("Sound", 0);

		}else {
			PlayerPrefs.SetInt("Sound", 1);

		}
	}
}

