using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class tap_red : MonoBehaviour {
	public static float timer;
	public static float finalTime;
	public static float buttontime;
	private float targetTime;
	private bool hasTime = false;
	public static bool hasPressed;
	public static float x;
	public static float y;
	private float distance;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		


		if (tap_bg.alpha >= 1) {
			transform.position = new Vector2 (100, 0);
		}

		if (GameController.scene == 1) {
			timer = 0;
			targetTime = 0;
			buttontime = 0;

			hasTime = false;
			hasPressed = false;
		}

		if (GameController.scene == 2) {
			if (hasTime == false) {
				buttontime = 0;
				targetTime = Random.Range (500, 850) / 100f;
				x = Random.Range (-700, 700) / 100f;
				y = Random.Range (-400, 400) / 100f;
				hasTime = true;

			}
			timer += Time.deltaTime;
			if (hasPressed == false) {
				if (timer > targetTime) {
					buttontime += Time.deltaTime;
					transform.position = new Vector2 (x, y);
					for (int i = 0; i < Input.touchCount; ++i) {
						if (Input.GetTouch (i).phase == TouchPhase.Began) {
							Vector2 p = Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position);
							distance = Vector3.Distance (p, gameObject.transform.position);
							if (distance <= 1.5f) {
								AudioCenter.playSound (GameController.soundId);
								finalTime = buttontime;
								Social.ReportScore ((long) finalTime * 10000000, "CgkIxvjEm5YGEAIQBw", (bool success) => {
								});
								if (finalTime < 0.1f) {
									Social.ReportProgress ("CgkIxvjEm5YGEAIQBg", 100.0f, (bool success) => {
									});
								}
								if (finalTime < 0.2f) {
									Social.ReportProgress ("CgkIxvjEm5YGEAIQBQ", 100.0f, (bool success) => {
									});
								}
								if (finalTime < 0.3f) {
									Social.ReportProgress ("CgkIxvjEm5YGEAIQBA", 100.0f, (bool success) => {
									});
								}
								if (finalTime < 0.4f) {
									Social.ReportProgress ("CgkIxvjEm5YGEAIQAw", 100.0f, (bool success) => {
									});
								}
								if (finalTime < 0.5f) {
									Social.ReportProgress ("CgkIxvjEm5YGEAIQAg", 100.0f, (bool success) => {
									});
								}
								if (finalTime < 1f) {
									Social.ReportProgress ("CgkIxvjEm5YGEAIQAQ", 100.0f, (bool success) => {
									});
								}
								transform.position = new Vector2 (200, 0);
								hasPressed = true;


							}
						}
					}
				}
			}
			
		}else {
			if (top_bg.alpha >= 1) {
				transform.position = new Vector2 (100, 0);
			}
		}
	}

}



