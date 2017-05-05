using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdsBanner : MonoBehaviour {

#if UNITY_EDITOR
	string adUnitIdTate = "unused";
	string adUnitIdYoko = "unused";
#elif UNITY_ANDROID
    //string adUnitIdTate = "ca-app-pub-5869235725006697/4481993169";
	//string adUnitIdYoko = "ca-app-pub-5869235725006697/2917861565";

    string adUnitIdTate = "ca-app-pub-3940256099942544/6300978111";
	string adUnitIdYoko = "ca-app-pub-3940256099942544/6300978111";
#elif UNITY_IPHONE
    //string adUnitIdTate = "ca-app-pub-5869235725006697/5958726364";
	//string adUnitIdYoko = "ca-app-pub-5869235725006697/1301527568";

	string adUnitIdTate = "ca-app-pub-3940256099942544/2934735716";
	string adUnitIdYoko = "ca-app-pub-3940256099942544/2934735716";
#else
    string adUnitIdTate = "unexpected_platform";
	string adUnitIdYoko = "unused";
#endif
	BannerView viewTate = null;        // 縦画面
	BannerView viewYoko = null;        // 横画面

	public int m_iHideCount;
	public void Show(bool _bFlag)
	{
		Debug.LogError(string.Format("showbanner:_bFlag={0} , hidecount={1}", _bFlag,m_iHideCount));
		if(_bFlag)
		{
			m_iHideCount -= 1;
			if(m_iHideCount <= 0)
			{
				m_iHideCount = 0;
				showAdBanner(DeviceOrientationDetector.Instance.orientation);
			}
		}
		else
		{
			if( 0 == m_iHideCount)
			{
				if (viewYoko != null)
				{
					viewYoko.Hide();
				}
				if(viewTate != null)
				{
					viewTate.Hide();
				}
			}
			m_iHideCount += 1;
		}
	}

	void showAdBanner(DeviceOrientationDetector.ORIENTATION _orientation)
	{
		if( _orientation == DeviceOrientationDetector.ORIENTATION.TATE)
		{
			if( viewYoko!= null)
			{
				viewYoko.Hide();
			}
			if (viewTate == null)
			{
				BannerView bannerViewTate = new BannerView(adUnitIdTate, AdSize.Banner, AdPosition.Bottom);
				// Create an empty ad request.
				AdRequest requestTate = new AdRequest.Builder().Build();
				// Load the banner with the request.
				bannerViewTate.LoadAd(requestTate);
				viewTate = bannerViewTate;
				viewTate.OnAdLoaded += View_OnAdLoaded;
			}
			else
			{
				viewTate.Show();
			}
		}
		else
		{
			if (viewTate != null)
			{
				viewTate.Hide();
			}
			if (viewYoko == null)
			{
				BannerView bannerViewYoko = new BannerView(adUnitIdYoko, AdSize.Banner, AdPosition.BottomLeft);
				// Create an empty ad request.
				AdRequest requestYoko = new AdRequest.Builder().Build();
				// Load the banner with the request.
				bannerViewYoko.LoadAd(requestYoko);
				viewYoko = bannerViewYoko;
				viewYoko.OnAdLoaded += View_OnAdLoaded;
			}
			else
			{
				viewYoko.Show();
			}
		}
	}	

	// Use this for initialization
	void Start () {
		m_iHideCount = 0;
		DeviceOrientationDetector.Instance.OnChangeOrientation.AddListener(OnChangedOrientation);
	}

	private void OnChangedOrientation(DeviceOrientationDetector.ORIENTATION _orientation)
	{
		if (m_iHideCount == 0)
		{
			showAdBanner(_orientation);
		}
	}
	private void View_OnAdLoaded(object sender, System.EventArgs e)
	{
		//refreshAds(m_strSceneNow);
		// 何かしたいならここ
		//view1.Hide();
		//view1.Show();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
