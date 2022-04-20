using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ButtonADS : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] private Button showAdButton;

    [SerializeField] private string androidAdUnitId = "Rewarded_Android";
    [SerializeField] private string iOSAdUnitId = "Rewarded_iOS";

    private string adUnitId;

    private void Awake()
    {
        adUnitId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? iOSAdUnitId
            : androidAdUnitId;
    }

    private void Start()
    {
        StartCoroutine(LoadRewardAD());
    } 
    private IEnumerator LoadRewardAD()
    {
        yield return new WaitForSeconds(1f);
        LoadAd();
    }

    public void LoadAd()
    {
        Debug.Log("Loading Ad: " + adUnitId);
        Advertisement.Load(adUnitId, this);
    }

    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        Debug.Log("Ad Loaded: " + adUnitId);

        if (adUnitId.Equals(adUnitId))
        {
            showAdButton.onClick.AddListener(ShowAd);
            showAdButton.interactable = true;
        }
    }

    public void ShowAd()
    {
        Advertisement.Show(adUnitId, this);
    }

    public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
    {
        if (adUnitId.Equals(adUnitId) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {
            Advertisement.Load(adUnitId, this);
            Cursor.visible = false;
            Time.timeScale = 1;
        }
    }

    public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit {adUnitId}: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {adUnitId}: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowStart(string adUnitId) { }
    public void OnUnityAdsShowClick(string adUnitId) { }

    private void OnDestroy()
    {
        showAdButton.onClick.RemoveAllListeners();
    }
}
