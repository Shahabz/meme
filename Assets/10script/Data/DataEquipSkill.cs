using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataEquipSkillParam : CsvDataParam
{
	public int equip_skill_id { get; set; }
	public int param { get; set; }
}

public class DataEquipSkill : CsvData<DataEquipSkillParam> {
	public const string FILENAME = "data/equip_skill";
	public DataEquipSkill()
	{
		if (Load(FILENAME) == false)
		{
			Save(FILENAME);
		}
	}

}
