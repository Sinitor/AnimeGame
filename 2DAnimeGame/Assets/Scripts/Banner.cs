using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Banner : MonoBehaviour
{
    [SerializeField] BannerPosition bannerPosition;

    [SerializeField] private string androidAdUnitId = "Banner_Android";
    [SerializeField] private string iOSAdUnitId = "Banner_iOS";

    private string adUnitId;

    private void Awake()
    {
        adUnitId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? iOSAdUnitId
            : androidAdUnitId;
    }

    private void Start()
    {
        Advertisement.Banner.SetPosition(bannerPosition);
        LoadBanner();
    }

    private IEnumerator LoadAdBanner()
    {
        yield return new WaitForSeconds(1f);
        LoadBanner();
    }

    public void LoadBanner()
    {
        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback = OnBannerLoaded,
            errorCallback = OnBannerError
        };

        Advertisement.Banner.Load(adUnitId, options);
    }
    private void OnBannerLoaded()
    {
        Debug.Log("Banner loaded");
        ShowBannerAd();
    }
    private void OnBannerError(string message)
    {
        Debug.Log($"Banner Error: {message}");
    }
    public void ShowBannerAd()
    {
        BannerOptions options = new BannerOptions
        {
            clickCallback = OnBannerClicked,
            hideCallback = OnBannerHidden,
            showCallback = OnBannerShown
        };
        Advertisement.Banner.Show(adUnitId, options);
    }
    public void HideBannerAd()
    {
        Advertisement.Banner.Hide();
    }
    private void OnBannerClicked() { }
    private void OnBannerShown() { }
    private void OnBannerHidden() { }
}