using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIShopList : CPanel {

	private string [] m_strShopNameKeyArr = new string[]
	{
		"name_shop_inn",
		"name_shop_weapon",
		"name_shop_item",
		"name_shop_station",
		"name_shop_search",
	};
	[SerializeField]
	private List<BtnShop> btnList = new List<BtnShop>();

	protected override void awake()
	{
		base.awake();
		for (int i = 0; i < btnList.Count; i++)
		{
			if(m_strShopNameKeyArr[i].Equals("name_shop_search"))
			{
			}

		}

	}

	protected override void panelStart()
	{
		//word.Instance.selectedLanguage = "en";
		base.panelStart();

		for( int i = 0;  i < btnList.Count; i++)
		{
			btnList[i].Initialize(m_strShopNameKeyArr[i]);
		}
	}



}
