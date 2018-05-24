using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;

public class FullscreenAd : MonoBehaviour {
	private InterstitialAd interstitial;
	void Start(){
		RequestInterstitial ();
	}

	void Update(){		
		if (interstitial.IsLoaded ()) {
			if (dots_repeat_button.repeat == true || mpRepeat.repeat == true || sc_repeat_button.repeat == true || tap_repeat_button.repeat == true)
				interstitial.Show ();
			
			
		}
	}


	public void RequestInterstitial()
	{
		

		#if UNITY_ANDROID
		string adUnitId = "ca-app-pub-2165871186692773/3049378442";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-2165871186692773/3049378442";
		#else
		string adUnitId = "unexpected_platform";
		#endif

		// Initialize an InterstitialAd.
		interstitial = new InterstitialAd(adUnitId);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder ()
		.AddTestDevice (AdRequest.TestDeviceSimulator)
		.AddTestDevice ("2021044583705143")
		.AddKeyword ("game")
		.SetGender (Gender.Male)

		.TagForChildDirectedTreatment(false)
		.AddExtra("color_bg", "9B30FF")
		.Build();

		// Load the interstitial with the request.
		interstitial.LoadAd(request);

			

		}

		}