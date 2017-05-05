using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIUserMenu : CPanel {

	[SerializeField]
	private BtnPlayer m_btnPlayer;		// これ名前がへん

	protected override void panelStart()
	{
		base.panelStart();
	}

	protected override void panelEndStart()
	{
		base.panelEndStart();
		m_btnPlayer.Close();
	}

}
