using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataEquipParam : CsvDataParam
{
	public int equip_id { get; set; }
}


public class DataEquip : CsvData<DataEquipParam>{
	public const string FILENAME = "data/equip";
	public DataEquip()
	{
		if (Load(FILENAME) == false)
		{
			Save(FILENAME);
		}
	}

}
