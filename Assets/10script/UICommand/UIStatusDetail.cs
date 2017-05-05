using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatusDetail : CPanel {

	[SerializeField]
	private Image m_imgChara;

	[SerializeField]
	private BannerCharaName m_bannerCharaName;

	private DataCharaParam m_dataCharaParam;
	private MasterCharaParam m_masterCharaParam;

	protected override void panelStart()
	{
		base.panelStart();

		m_dataCharaParam = DataManager.Instance.selectedDataCharaParam;

		m_bannerCharaName.Initialize(m_dataCharaParam);

		m_masterCharaParam = DataManager.Instance.masterChara.Get(m_dataCharaParam.chara_id);
		Debug.LogError(m_masterCharaParam.filename);
		m_imgChara.sprite = SpriteManager.Instance.LoadSprite(m_masterCharaParam.filename);

		float width = CanvasSize.Instance.canvasHeight * 640.0f / 1136.0f;
		m_imgChara.rectTransform.sizeDelta = new Vector2(width, 0);

		AdsManager.Instance.ShowBanner(false);
		
	}

	protected override void panelEndStart()
	{
		base.panelEndStart();
		AdsManager.Instance.ShowBanner(true);
	}
}




