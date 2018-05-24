using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap_bg : MonoBehaviour {
	public static float timer;
	public static float alpha;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (0, 0);
		Color tmp = GetComponent<SpriteRenderer> ().color;
		if (GameController.scene == 1) {
			timer = 0;
			tmp.a = 0;
		}

		if (GameController.scene == 2) {

			if (tap_red.buttontime != 0f) {
				tmp.a += 0.015f;
			}
			timer += Time.deltaTime;
			if (timer >= 3 && timer <= 4.5f) {
				tmp.a += 0.015f;
			}
			if (timer >= 4.5f && timer <= 7) {
				tmp.a -= 0.015f;
			}
		}
		GetComponent<SpriteRenderer> ().color = tmp;
		alpha = tmp.a;
	}
}

