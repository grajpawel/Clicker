using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class dotsController : MonoBehaviour {
	
	public static int score;
	public static bool gameOn;
	private bool hasPublished;
	// Use this for initialization
	void Start () {
		gameOn = true;
		hasPublished = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (GameController.scene == 1) {
			
			gameOn = true;
			if (top_bg.alpha >= 1) {
				score = 0;
			}
		}
		if (GameController.scene == 5) {
			if (score >= 50) {
				Social.ReportProgress ("CgkIxvjEm5YGEAIQCg", 100.0f, (bool success) => {
				});
			}
			if (score >= 100) {
				Social.ReportProgress ("CgkIxvjEm5YGEAIQCw", 100.0f, (bool success) => {
				});
			}
			if (score >= 150) {
				Social.ReportProgress ("CgkIxvjEm5YGEAIQDA", 100.0f, (bool success) => {
				});
			}
			if (score >= 200) {
				Social.ReportProgress ("CgkIxvjEm5YGEAIQDQ", 100.0f, (bool success) => {
				});
			}
			if (score >= 250) {
				Social.ReportProgress ("CgkIxvjEm5YGEAIQDg", 100.0f, (bool success) => {
				});
			}
			if (score >= 300) {
				Social.ReportProgress ("CgkIxvjEm5YGEAIQDw", 100.0f, (bool success) => {
				});
			}
			if (score >= 350) {
				Social.ReportProgress ("CgkIxvjEm5YGEAIQEA", 100.0f, (bool success) => {
				});
			}
			if (score >= 400) {
				Social.ReportProgress ("CgkIxvjEm5YGEAIQEQ", 100.0f, (bool success) => {
				});
			}
			if (wheel1.isVisible == true && wheel2.isVisible == true && wheel3.isVisible == true && wheel4.isVisible == true && wheel5.isVisible == true) {
				if (hasPublished == false) {
					Social.ReportScore (score, "CgkIxvjEm5YGEAIQCQ", (bool success) => {
					});
					hasPublished = true;
				}
				gameOn = false;
			}
		}
	}
}
