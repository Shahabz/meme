using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FrameEquipListHeader
{
	public EQUIP_TYPE equip_type;
	public Sprite sprite;
	public string title;
}

public class UIEquipTop : CPanel {

	public GameObject m_goContentsRoot;
	public FrameEquipListHeader[] infoArr;

	protected override void panelStart()
	{
		base.panelStart();

		DeleteObjects<FrameEquipList>(m_goContentsRoot);

		foreach(FrameEquipListHeader info in infoArr)
		{
			FrameEquipList script = PrefabManager.Instance.MakeScript<FrameEquipList>("FrameEquipList", m_goContentsRoot);
			script.Initialize(info);
		}

	}


}
