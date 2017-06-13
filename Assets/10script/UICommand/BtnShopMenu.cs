using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnShopMenu : MonoBehaviour {

	[SerializeField]
	private Text m_txtTitle;

	private UIShopMenu.Menu m_menu;

	public void Initialize(UIShopMenu.Menu _menu)
	{
		m_menu = _menu;
		m_txtTitle.text = _menu.title;
	}
}
