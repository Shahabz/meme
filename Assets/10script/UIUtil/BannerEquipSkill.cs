using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BannerEquipSkill: MonoBehaviour {

	[SerializeField]
	private Text m_txtTitle;

	private DataEquipSkillParam m_dataParam;
	private MasterEquipSkillParam m_masterParam;

	public void Initialize(DataEquipSkillParam _dataParam , MasterEquipSkillParam _masterParam )
	{
		m_dataParam = _dataParam;
		m_masterParam = _masterParam;

		m_txtTitle.text = m_masterParam.name;
		string strAddText = "";
		if( m_masterParam.math.Equals("plus"))
		{
			strAddText = string.Format("+{0}", m_dataParam.param);
		}
		else if (m_masterParam.math.Equals("rate"))
		{
			strAddText = string.Format("({0}%)", m_dataParam.param);
		}
		m_txtTitle.text += strAddText;
	}

}
