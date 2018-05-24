using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel2 : MonoBehaviour {
	public static float x;
	public static float y;
	private float timer;
	public static bool hasPlace;
	public static bool isVisible;
	private float distance;
	public static float tpTime;
	private float startDelay;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (GameController.scene == 1) {
			tmp.a = 1;
			transform.position = new Vector2 (6, 6);
			startDelay = 5;
			hasPlace = false;
			tpTime = 3;
			isVisible = false;
			timer = 0;
		}
		if (hasPlace == false) {
			x = Random.Range (-700, 700) / 100f;
			y = Random.Range (-400, 400) / 100f;
			hasPlace = true;
		}
		if (GameController.scene == 5){
			if (dotsController.gameOn == true){
				timer += Time.deltaTime;
				if (timer >= tpTime + startDelay){
					isVisible = true;
					transform.position = new Vector2 (x, y);

					for (int i = 0; i < Input.touchCount; ++i) {
						if (Input.GetTouch (i).phase == TouchPhase.Began) {
							Vector2 p = Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position);
							distance = Vector3.Distance (p, gameObject.transform.position);
							if (distance <= 1.2f) {
								AudioCenter.playSound (GameController.soundId);
								timer = 0;
								transform.position = new Vector2 (6, 6);
								tpTime = tpTime - 0.05f;
								hasPlace = false;
								isVisible = false;
								dotsController.score++;
								startDelay = 0;
							}
						}
					}
				}
			} else {
				tmp.a -= 0.015f;

				if (tmp.a <= 0) {
					tmp.a = 0;
				}
			}
		}
		GetComponent<SpriteRenderer> ().color = tmp;
	}
}
