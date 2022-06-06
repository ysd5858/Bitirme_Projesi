using System.Collections;
using UnityEngine;
using GoogleMobileAds.Api;

public class Reklam_Banner : MonoBehaviour
{
    public string bannerID = "ca-app-pub-3940256099942544/6300978111";
    public string appId = "ca-app-pub-7397063878943185~2764647606";
    public AdPosition adPosition;
    public BannerView bannerView;
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        StartCoroutine(Bekleme());        
    }
    
    public void RequestBanner()
    {
        this.bannerView = new BannerView(bannerID, AdSize.Banner, adPosition);
        AdRequest request = new AdRequest.Builder().Build();
        this.bannerView.LoadAd(request);        
    }
    IEnumerator Bekleme()
    {
        yield return new WaitForSeconds(2.0f);
        RequestBanner();
    }
}
