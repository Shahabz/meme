using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconItem : MonoBehaviour {

	[SerializeField]
	private Image m_imgIcon;

	[SerializeField]
	private Text m_txtName;

	public void Initialize( DataItemParam _item )
	{
		MasterItemParam param = DataManager.Instance.masterItem.Get(_item.item_id);

		m_txtName.text = param.item_name;
	}

	public void Initialize( DataEquipParam _equip)
	{
		MasterEquipParam param = DataManager.Instance.masterEquip.Get(_equip.equip_id);

		m_txtName.text = param.name;

	}


}
