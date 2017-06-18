using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBattle : CPanel {

	[SerializeField]
	private Image m_imgPlayer;
	[SerializeField]
	private Image m_imgEnemy;

	private DataCharaParam m_dataPlayer;
	private DataCharaParam m_dataEnemy;

	[SerializeField]
	private BannerBattleParams m_bannerPlayer;
	[SerializeField]
	private BannerBattleParams m_bannerEnemy;

	protected override void panelStart()
	{
		base.panelStart();

		m_dataPlayer = new DataCharaParam();
		m_dataPlayer.chara_id = 2;
		m_bannerPlayer.Initialize(m_dataPlayer);

		m_dataEnemy = new DataCharaParam();
		m_dataEnemy.chara_id = 1;
		m_bannerEnemy.Initialize(m_dataEnemy);


	}

}
