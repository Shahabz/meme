using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBattleSkill : CPanel {

	[SerializeField]
	private GameObject m_goIconRoot;

	private IconBattleSkill[] m_iconBattleSkillArr;

	protected override void panelStart()
	{
		base.panelStart();

		DeleteObjects<IconBattleSkill>(m_goIconRoot);
		//m_iconBattleSkillArr = m_goIconRoot.GetComponentsInChildren<IconBattleSkill>();
		for( int i = 0; i < DataManager.Instance.dataBattleSkill.list.Count ; i++)
		{
			IconBattleSkill script = PrefabManager.Instance.MakeScript<IconBattleSkill>("IconBattleSkill", m_goIconRoot);
			script.Initialize(i);
		}

	}

}
