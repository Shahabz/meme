using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class BannerNotice : MonoBehaviour {

	[SerializeField]
	private Button m_btn;

	[SerializeField]
	private Image m_imgIcon;

	[SerializeField]
	private Text m_txtTitle;

	[SerializeField]
	private Text m_txtDetail;

	[SerializeField]
	private Text m_txtDate;

	public void Initialize(MasterNoticeParam _param)
	{
		m_imgIcon.sprite = SpriteManager.Instance.LoadSprite(string.Format("{0}", _param.notice_icon));
		m_txtTitle.text = _param.title;
		m_txtDetail.text = _param.detail_mini;
		m_txtDate.text = _param.date_start;
	}

}
