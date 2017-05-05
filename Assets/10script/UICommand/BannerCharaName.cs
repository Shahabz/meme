using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class BannerCharaName : MonoBehaviour {

	private DataCharaParam m_dataCharaParam;

	[SerializeField]
	private Text m_txtName;

	public void Initialize(DataCharaParam _param)
	{
		m_dataCharaParam = _param;
		MasterCharaParam masterCharaParam = DataManager.Instance.masterChara.Get(m_dataCharaParam.chara_id);
		m_txtName.text = masterCharaParam.name;

		gameObject.GetComponent<Button>().onClick.AddListener(() =>
		{
			DataManager.Instance.selectedDataCharaParam = m_dataCharaParam;
			UIAssistant.main.ShowPage("2_1_1status_detail");
		});
	}


}
