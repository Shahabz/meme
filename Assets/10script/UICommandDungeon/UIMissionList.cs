using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMissionList : CPanel {

	[SerializeField]
	private GameObject m_goRoot;

	protected override void panelStart()
	{
		base.panelStart();

		DeleteObjects<BannerMission>(m_goRoot);

		foreach( DataMissionParam param in DataManager.Instance.dataMission.list)
		{
			//MasterMissionParam masterParam = DataManager.Instance.masterMission.Get(param.mission_id);
			BannerMission banner = PrefabManager.Instance.MakeScript<BannerMission>("PrefBannerMission", m_goRoot);
			banner.Initialize(param);
		}

	}

}
