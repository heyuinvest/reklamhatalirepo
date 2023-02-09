using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdManagerInt : MonoBehaviour
{
    private InterstitialAd interstitial;

    void Start()
    {
        MobileAds.Initialize(initstatus => { });

        RequestInterstitial();

    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-6526770109674078/4354745610";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-6526770109674078/1925406280";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    public void InterAds()
    {



        if (interstitial.IsLoaded())
            interstitial.Show();


    }
}
