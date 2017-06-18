using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconBattleSkill : MonoBehaviour {

	[SerializeField]
	private Image m_imgIcon;
	[SerializeField]
	private Text m_txtName;

	[SerializeField]
	private Text m_txtTurn;

	private DataBattleSkillParam m_dataParam;
	private MasterBattleSkillParam m_masterParam;

	public void Initialize(DataBattleSkillParam _dataParam , MasterBattleSkillParam _masterParam)
	{
		m_dataParam = _dataParam;
		m_masterParam = _masterParam;

		m_txtName.text = _masterParam.name;

	}
	public void Initialize( int _iIndex)
	{
		DataBattleSkillParam dataParam = DataManager.Instance.dataBattleSkill.list[_iIndex];
		MasterBattleSkillParam masterParam = DataManager.Instance.masterBattleSkill.Get(dataParam.battle_skill_id);
		Initialize(dataParam, masterParam);
	}

}
