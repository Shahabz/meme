using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDangeonSelect : CPanel {

	[SerializeField]
	RectTransform rtScrollView;

	[SerializeField]
	GridLayoutGroup gridLayoutGroup;

	[SerializeField]
	private List<BannerDungeon> listBannerDungeon = new List<BannerDungeon>();

	[SerializeField]
	private GameObject m_goContents;

	protected override void awake()
	{
		base.awake();
		DeviceOrientationDetector.Instance.OnChangeOrientation.AddListener(OnChangeOrientation);
	}
	private void OnChangeOrientation(DeviceOrientationDetector.ORIENTATION _orientation)
	{
		if(_orientation == DeviceOrientationDetector.ORIENTATION.TATE)
		{
			rtScrollView.sizeDelta = new Vector2(370.0f, 390.0f);
			gridLayoutGroup.cellSize = new Vector2(350.0f, 50.0f);
		}
		else
		{
			rtScrollView.sizeDelta = new Vector2(490.0f, 184.8f);
			gridLayoutGroup.cellSize = new Vector2(235.0f, 60.0f);
		}
	}

	protected override void panelStart()
	{
		OnChangeOrientation(DeviceOrientationDetector.Instance.orientation);
		if (0 < listBannerDungeon.Count)
		{
			foreach (BannerDungeon banner in listBannerDungeon)
			{
				Destroy(banner.gameObject);
			}
		}
		listBannerDungeon.Clear();

		for ( int i = 0; i < 1; i++)
		{
			BannerDungeon script = PrefabManager.Instance.MakeScript<BannerDungeon>("prefab/BannerDungeon", m_goContents);
			script.Initialize(i);
			listBannerDungeon.Add(script);
		}

		/*
		SkitConnector.Instance.root.Initialize("1MeYvualTlwUmGrO9Wx9CcWlQCCTZ3aVxmZa1Gm33O_A", "oc91q9y", "notice_tutorial");
		base.panelStart();

		foreach(BannerNotice notice in m_bannerNoticeList)
		{
			Destroy(notice.gameObject);
		}
		m_bannerNoticeList.Clear();

		foreach(MasterNoticeParam param in DataManager.Instance.masterNotice.list)
		{
			BannerNotice notice = PrefabManager.Instance.MakeScript<BannerNotice>("prefab/BannerNotice", m_goContentsRoot);
			notice.Initialize(param);
			m_bannerNoticeList.Add(notice);
		}
		*/
	}

}
