using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BannerMission : MonoBehaviour {

	[SerializeField]
	private Text m_txtTitle;

	[SerializeField]
	private Text m_txtRate;

	[SerializeField]
	private Text m_txtPrize;

	public void Initialize( DataMissionParam _param)
	{
		Debug.LogError(DataManager.Instance.masterMission.list.Count);
		MasterMissionParam masterParam = DataManager.Instance.masterMission.Get(_param.mission_id);
		m_txtTitle.text = masterParam.title;


	}
}
