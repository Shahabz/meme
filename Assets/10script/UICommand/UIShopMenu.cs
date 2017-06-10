using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShopMenu : CPanel {

	[SerializeField]
	private GameObject m_goMenuRoot;

	[SerializeField]
	private TextAsset m_txtMenuText;

	public TextAsset menuText { get { return m_txtMenuText; } }

	[System.Serializable]
	public class Menu
	{
		public string title;
		public string type;
	}
	[System.Serializable]
	public class Data
	{
		public string name;
		public Menu[] menuArr;
	}

	public Data[] m_menuData;

	protected override void panelStart()
	{
		base.panelStart();

		DeleteObjects<BtnShop>(m_goMenuRoot);

		for( int i = 0; i < 3; i++)
		{
			//GameObject obj = PrefabManager.Instance.MakeObject("BtnShopMenu" , m_goMenuRoot);
		}
	}


}
