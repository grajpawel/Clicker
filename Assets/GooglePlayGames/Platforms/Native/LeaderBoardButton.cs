using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class LeaderBoardButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (top_bg.alpha >= 1) {
			if (GameController.scene == 1) {
				transform.position = new Vector2 (8.1f, 2.8f);
			} else {
				
				transform.position = new Vector2 (-150, -15);
			}
		}
	}
	public void OnTap(){
		Social.ShowLeaderboardUI();

	}
}
