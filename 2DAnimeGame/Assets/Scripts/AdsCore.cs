using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class AdsCore : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] private string androidGameId;
    [SerializeField] private string iOSGameId;
    [SerializeField] private bool testMode;

    private string gameId;

    void Awake()
    {
        InitializeAds();
    }

    public void InitializeAds()
    {
        gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? iOSGameId
            : androidGameId;

        Advertisement.Initialize(gameId, testMode);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }
}
