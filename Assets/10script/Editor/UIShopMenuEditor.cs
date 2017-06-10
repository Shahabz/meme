using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using MiniJSON;

[CustomEditor(typeof(UIShopMenu))]
public class UIShopMenuEditor : Editor {

	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		UIShopMenu uiShopMenu = target as UIShopMenu;
		if (GUILayout.Button("Read Data"))
		{
			//var json = Json.Deserialize(uiShopMenu.menuData.text) as Dictionary<string,object>;
			IList familyList = (IList)Json.Deserialize(uiShopMenu.menuText.text);

			int num = familyList.Count;

			uiShopMenu.m_menuData = new UIShopMenu.Data[num];

			int iShopIndex = 0;
			foreach ( IDictionary dict in familyList)
			{
				UIShopMenu.Data data = new UIShopMenu.Data();
				data.name = (string)dict["name"];
				//IList menu_list = (IList)Json.Deserialize((string)dict["menu"]);
				IList menu_list = (IList)dict["menu"];
				int menu_num = menu_list.Count;

				data.menuArr = new UIShopMenu.Menu[menu_num];
				int iMenuIndex = 0;
				foreach( IDictionary menu in menu_list)
				{
					UIShopMenu.Menu m = new UIShopMenu.Menu();
					m.title = (string)menu["title"];
					m.type = (string)menu["type"];
					data.menuArr[iMenuIndex] = m;
					iMenuIndex += 1;
				}

				uiShopMenu.m_menuData[iShopIndex] = data;
				iShopIndex += 1;
			}

		}

	}

}
