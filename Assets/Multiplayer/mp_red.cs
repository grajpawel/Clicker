using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mp_red : MonoBehaviour {
	public static float timer;

	private float buttontime;
	private float targetTime;
	private bool hasTime;
	public static bool hasPressed;
	public static int winner;
	public static int player1score = 0;
	public static int player2score = 0;
	public GUIStyle guiStyleScore = new GUIStyle();
	// Use this for initialization
	void Start () {
		guiStyleScore.fontSize = Screen.width / 20;
	}

	// Update is called once per frame
	void Update () {
		Color tmpScore = guiStyleScore.normal.textColor;
		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (tmpScore.a <= 0)
			tmpScore.a = 0;
		
		if (tmpScore.a >= 1) 
			tmpScore.a = 1;
		
		if (SC_bg.alpha >= 1) {
			transform.position = new Vector2 (100, 0);
		}

		if (GameController.scene == 1) {
			timer = 0;
			targetTime = 0;
			buttontime = 0;

			hasTime = false;
			hasPressed = false;
			if (mpRepeat.zeroScore == true) {
				if (top_bg.alpha >= 1) {
					player1score = 0;
					player2score = 0;
				}
			}
		}

		if (GameController.scene == 4) {
			if (hasPressed == true) {
				tmpScore.a += 0.015f; 
				tmp.a -= 0.015f;

			}
			if (hasTime == false) {
				buttontime = 0;
				targetTime = Random.Range (500, 1200) / 100f;
				hasTime = true;
			}
			timer += Time.deltaTime;
			if (hasPressed == false) {
				if (timer >= targetTime) {
					buttontime += Time.deltaTime;
					transform.position = new Vector2 (0, 0);
					for (int i = 0; i < 1; ++i) {
						if (Input.GetTouch (0).phase == TouchPhase.Began) {
							Vector2 p = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);

							AudioCenter.playSound (GameController.soundId);
							if (p.y <= 0) {
								winner = 1;
								player1score++;
								hasPressed = true;
							
							} else {
								hasPressed = true;
								winner = 2;
								player2score++;
							}
								

							}
						}
					} else {
					for (int i = 0; i < Input.touchCount; ++i) {
						if (Input.GetTouch (i).phase == TouchPhase.Began) {
							timer = 0;
						}
					
						}
					}
				}

		}else {
			tmpScore.a -= 0.016f;


			if (top_bg.alpha >= 0.95) {
				transform.position = new Vector2 (100, 0);
					tmp.a = 1;

			}
		}
		GetComponent<SpriteRenderer> ().color = tmp;
		guiStyleScore.normal.textColor = tmpScore;
	}
	void OnGUI(){
		
		GUI.Label(new Rect(Screen.width/2, Screen.height/1.2f, 0, 0),player1score.ToString()+" - "+player2score.ToString(), guiStyleScore);
		GUIUtility.RotateAroundPivot (180, new Vector2 (Screen.width / 2, Screen.height / 6));
		GUI.Label(new Rect(Screen.width/2, Screen.height/6, 0, 0),player2score.ToString()+" - "+player1score.ToString(), guiStyleScore);

}
}

