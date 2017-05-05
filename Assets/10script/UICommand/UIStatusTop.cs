using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStatusTop : CPanel {

	[SerializeField]
	private GameObject m_rootBanner;
	[SerializeField]
	private List<BannerCharaName> m_bannerCharaName = new List<BannerCharaName>();

	protected override void panelStart()
	{
		base.panelStart();
		foreach(BannerCharaName banner in m_bannerCharaName)
		{
			Destroy(banner.gameObject);
		}
		m_bannerCharaName.Clear();
		foreach(DataCharaParam param in DataManager.Instance.dataChara.list)
		{
			BannerCharaName banner = PrefabManager.Instance.MakeScript<BannerCharaName>("prefab/BannerCharaName", m_rootBanner);
			banner.Initialize(param);
			m_bannerCharaName.Add(banner);
		}
	}

}
