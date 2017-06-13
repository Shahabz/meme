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

	private Data m_dataActive;

	protected override void panelStart()
	{
		base.panelStart();

		DeleteObjects<BtnShopMenu>(m_goMenuRoot);

		foreach( Data d in m_menuData)
		{
			if (DataManager.Instance.showShop.Equals(d.name)){
				m_dataActive = d;
				break;
			}
		}

		for( int i = 0; i < m_dataActive.menuArr.Length; i++)
		{
			BtnShopMenu script = PrefabManager.Instance.MakeScript<BtnShopMenu>("BtnShopMenu", m_goMenuRoot);
			script.Initialize(m_dataActive.menuArr[i]);
		}
	}


}
