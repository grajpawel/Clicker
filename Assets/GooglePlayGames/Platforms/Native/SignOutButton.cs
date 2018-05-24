using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class SignOutButton : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Color tmp = GetComponent<Image> ().color;
		Color tmpText = text.GetComponent<Text>().color;
		tmpText.a = tmp.a;
		text.GetComponent<Text> ().color = tmpText;
		if (settings.settingsOn == true) {
			
			if (tmp.a >= 1) {
				tmp.a = 1;
			}
			tmp.a += GameController.appearSpeed;
		} else {
			tmp.a -= GameController.appearSpeed;
			if (tmp.a <= 0) {
				tmp.a = 0;
			}
			if (top_bg.alpha >= 1) {
			}
		}





		GetComponent<Image> ().color = tmp;
	}
	public void OnTap(){
		PlayGamesPlatform.Instance.SignOut ();
	}
		
}
