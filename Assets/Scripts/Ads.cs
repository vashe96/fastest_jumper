using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour, IUnityAdsListener
{
    private string playStoreId = "3643491";

    private string interstitialAd = "video";
    private string rewardedVideoAd = "rewardedVideo";


    private void Start()
    {
        Advertisement.AddListener(this);
        InitializeAdvertisement();
    }

    private void InitializeAdvertisement()
    {
        Advertisement.Initialize(playStoreId);
    }

    public bool isInterstitialReady()
    {
        return Advertisement.IsReady(interstitialAd);
    }

    public bool isRewardedVideoReady()
    {
        return Advertisement.IsReady(rewardedVideoAd);
    }

    public void PlayInterstitialAd()
    {
        if(!Advertisement.IsReady(interstitialAd)) { return; }
        Advertisement.Show(interstitialAd);
    }

    public void PlayRewardedVideoAd()
    {
        if (!Advertisement.IsReady(rewardedVideoAd)) { return; }
        Advertisement.Show(rewardedVideoAd);
    }

    public void OnUnityAdsReady(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        switch(showResult)
        {
            case ShowResult.Failed:
                break;
            case ShowResult.Skipped:
                break;
            case ShowResult.Finished:
                if (placementId == rewardedVideoAd)
                    return;
                break;
        }
    }
}
