using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShopChara : CPanel {

	[SerializeField]
	private SpriteHolder m_shChara;

	[SerializeField]
	private Image m_imgChara;

	protected override void panelStart()
	{
		base.panelStart();

		Sprite sprChara = m_shChara.Get(DataManager.Instance.showShop);
		if( sprChara!= null)
		{
			m_imgChara.sprite = sprChara;
		}

	}

}
