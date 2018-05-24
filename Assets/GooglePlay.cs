using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class GooglePlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayGamesPlatform.Activate ();
		Social.localUser.Authenticate ((bool success) => {
		});
	}
	
	// Update is called once per frame
	void Update () {

	}
}
