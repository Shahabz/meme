using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class BannerUserItem : MonoBehaviour {

	[SerializeField]
	private Button m_btn;

	[SerializeField]
	private Image m_imgIcon;

	[SerializeField]
	private Text m_txtName;

	[SerializeField]
	private Text m_txtNum;

	public void Initialize(DataItemParam _param)
	{
		MasterItemParam masterItemParam = DataManager.Instance.masterItem.Get(_param.item_id);
		m_imgIcon.sprite = SpriteManager.Instance.LoadSprite(string.Format("texture/{0}", masterItemParam.filename));
		m_txtName.text = masterItemParam.name_ja;
		m_txtNum.text = string.Format("x{0}", _param.num);
	}

}
