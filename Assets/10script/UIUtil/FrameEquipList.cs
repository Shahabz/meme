using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameEquipList : MonoBehaviourEx {

	private EQUIP_TYPE m_eEquipType;
	private FrameEquipListHeader m_headerInfo;

	[SerializeField]
	private GameObject m_goContentsRoot;

	[SerializeField]
	private Text m_txtTitle;
	[SerializeField]
	private Image m_imgIcon;

	public void Initialize(FrameEquipListHeader _header)
	{
		m_headerInfo = _header;
		m_eEquipType = m_headerInfo.equip_type;

		m_txtTitle.text = m_headerInfo.title;
		m_imgIcon.sprite = m_headerInfo.sprite;

		DeleteObjects<BannerEquipSkill>(m_goContentsRoot);

		foreach( DataEquipSkillParam dataParam in DataManager.Instance.dataEquipSkill.list)
		{
			MasterEquipSkillParam masterParam = DataManager.Instance.masterEquipSkill.Get(dataParam.equip_skill_id);
			if ( (int)m_eEquipType == masterParam.equip_type)
			{
				BannerEquipSkill script = PrefabManager.Instance.MakeScript<BannerEquipSkill>("BannerEquipSkill", m_goContentsRoot);
				script.Initialize(dataParam, masterParam);
			}
		}

		


	}

}
