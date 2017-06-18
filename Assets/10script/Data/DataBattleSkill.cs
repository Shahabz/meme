using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBattleSkillParam : CsvDataParam
{
	public int battle_skill_id { get; set; }
	public int turn { get; set; }
}

public class DataBattleSkill : CsvData<DataBattleSkillParam> {
	public const string FILENAME = "data/battle_skill";
	public DataBattleSkill()
	{
		if (Load(FILENAME) == false)
		{
			Save(FILENAME);
		}
	}

}
