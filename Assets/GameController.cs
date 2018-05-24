using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public static int scene;
	public static int soundId;
	private bool hasloadedsound = false;
	private bool hasloadedsilence = false;
	public static float appearSpeed = 0.05f;

	// Use this for initialization
	void Start () {
		scene = 1;

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (scene);
		if (AudioListener.volume == 1){
			if (hasloadedsound == false) {
				soundId = AudioCenter.loadSound ("test");
				hasloadedsound = true;
				hasloadedsilence = false;
			}
		
		} else {
			if (hasloadedsilence == false) {
				soundId = AudioCenter.loadSound ("silence");
				hasloadedsilence = true;
				hasloadedsound = false;
			}
}
	}
}


