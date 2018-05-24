using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mp_instruction : MonoBehaviour {
	public static bool isVisible;
	private GameObject inst1;
	private GameObject inst2;
	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (50, 0);
		inst1 = GameObject.Find ("mp_inst1");
		inst2 = GameObject.Find ("mp_inst2");
	}

	// Update is called once per frame
	void Update () {
		if (GameController.scene == 1) {
			isVisible = true;
		}
		if (top_bg.alpha >= 1) {
			if (GameController.scene == 4) {
				if (isVisible == true) {
					inst1.transform.position = new Vector2 (0, -1.5f);
					inst2.transform.position = new Vector2 (0, 1.5f);
					inst2.transform.localEulerAngles = new Vector3 (0, 0, 180);
				} else {
					inst1.transform.position = new Vector2 (0, -22);
					inst2.transform.position = new Vector2 (0, 22);
				}

			} else {
				inst1.transform.position = new Vector2 (0, -22);
				inst2.transform.position = new Vector2 (0, 22);
				isVisible = false;
			}
		}
		if (mp_bg.alpha >= 1){
			inst1.transform.position = new Vector2 (0, -22);
			inst2.transform.position = new Vector2 (0, 22);
		}
	}
}
