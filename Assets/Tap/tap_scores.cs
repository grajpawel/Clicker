using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap_scores : MonoBehaviour {
	public GUIStyle guiStyleScore = new GUIStyle();
	public GUIStyle guiStyleHighScore = new GUIStyle();
	public GUIStyle guiStyleScoreText = new GUIStyle();
	public GUIStyle guiStyleHighScoreText = new GUIStyle();
	// Use this for initialization
	void Start () {
		guiStyleScore.fontSize = Screen.width / 10;
		guiStyleHighScore.fontSize = Screen.width / 15;
		guiStyleHighScoreText.fontSize = Screen.width / 20;
		guiStyleScoreText.fontSize = Screen.width / 20;
	}

	// Update is called once per frame
	void Update () {

		Color tmpScore = guiStyleScore.normal.textColor;
		Color tmp = guiStyleHighScore.normal.textColor;

		if (tap_red.hasPressed == true) {
			if (PlayerPrefs.HasKey ("tapHighscore")) {
				if (PlayerPrefs.GetFloat ("tapHighscore") > tap_red.finalTime) {
					PlayerPrefs.SetFloat ("tapHighscore", tap_red.finalTime);
				}	
			} else {
				PlayerPrefs.SetFloat ("tapHighscore",tap_red.finalTime);
			}
			tmp.a += 0.015f;
			tmpScore.a += 0.015f;
			if (tmp.a >= 1) {
				tmp.a = 1;
			}
			if (tmpScore.a >= 1) {
				tmpScore.a = 1;
			}


		} else {
			tmp.a -= 0.015f;
			tmpScore.a -= 0.015f;
			if (tmp.a <= 0) {
				tmp.a = 0;
			}
			if (tmpScore.a <= 0) {
				tmpScore.a = 0;
			}
		}

		guiStyleHighScore.normal.textColor = tmp;
		guiStyleScore.normal.textColor = tmpScore;
		guiStyleHighScoreText.normal.textColor = tmp;
		guiStyleScoreText.normal.textColor = tmp;
	}
	void OnGUI(){

		GUI.Label(new Rect(Screen.width/2, Screen.height/7f, 0, 0),"Your time", guiStyleScoreText);
		GUI.Label(new Rect(Screen.width/2, Screen.height/3, 0, 0),tap_red.finalTime.ToString("F4")+" s", guiStyleScore);
		GUI.Label(new Rect(Screen.width/2, Screen.height/1.6f, 0, 0),"Best time", guiStyleHighScoreText);
		GUI.Label(new Rect(Screen.width/2, Screen.height/1.3f, 0, 0),PlayerPrefs.GetFloat("tapHighscore").ToString("F4")+" s", guiStyleHighScore);
	}
}


