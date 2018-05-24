using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingButtonsTeleport : MonoBehaviour {
	private Vector2 startpos;
	// Use this for initialization
	void Start () {
		startpos = transform.position;
		TeleportAway ();
	}
	
	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<Image> ().color;
		if (settings.settingsOn == true)
			transform.position = startpos;
		else {
			if (tmp.a <= 0)
				TeleportAway ();
		}
	
	}
	void TeleportAway(){
		transform.position = new Vector2 (startpos.x * 2, startpos.y * 2);

	}
}
