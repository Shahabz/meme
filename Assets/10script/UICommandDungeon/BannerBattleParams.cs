using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BannerBattleParams : MonoBehaviour {

	[SerializeField]
	private Text m_txtLevel;

	[SerializeField]
	private Text m_txtName;

	[SerializeField]
	private Text m_txtJob;

	[SerializeField]
	private EnergyBar m_ebHp;

	private DataCharaParam m_param;

	public void Initialize(DataCharaParam _param)
	{
		m_param = _param;

		m_txtLevel.text = string.Format("Lv.{0}", m_param.level);
		m_txtName.text = string.Format("{0}", DataManager.Instance.masterChara.GetName(_param.chara_id));
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
