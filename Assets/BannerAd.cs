using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
public class BannerAd : MonoBehaviour {
	public BannerView bannerView;
	void Start(){
		RequestBanner ();
		}
	void Update(){
		if (GameController.scene == 1 && dots_repeat_button.repeat == false && mpRepeat.repeat == false && sc_repeat_button.repeat == false && tap_repeat_button.repeat == false)
			bannerView.Show ();
		else
			bannerView.Hide ();
	}

	public void RequestBanner()
	{
		#if UNITY_EDITOR
		string adUnitId = "unused";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-2165871186692773/1550795641";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-2165871186692773/1550795641";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		// Create a 320x50 banner at the top of the screen.
		bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder ()
		.AddTestDevice (AdRequest.TestDeviceSimulator)

		.AddKeyword ("game")
		.SetGender (Gender.Male)

		.TagForChildDirectedTreatment(false)
		.AddExtra("color_bg", "9B30FF")
		.Build();
	
		//AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
	
		bannerView.LoadAd(request);

		}
		}

	
	