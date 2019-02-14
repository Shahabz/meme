using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterBattleSkillParam : CsvDataParam
{
	public int battle_skill_id { get; set; }
	public string battle_skill_type { get; set; }

	public string name { get; set; }
	public string description { get; set; }

	public int turn { get; set; }

	public int atk { get; set; }
	public int def { get; set; }
	public int mat { get; set; }
	public int mdf { get; set; }
	public int agi { get; set; }
	public int dex { get; set; }
	public int eva { get; set; }
	public int cri { get; set; }
	public int luc { get; set; }
	public int att_fire { get; set; }
	public int att_water { get; set; }
	public int att_wind { get; set; }
	public int att_eath { get; set; }
	public int att_time { get; set; }

}

public class MasterBattleSkill : CsvData<MasterBattleSkillParam> {
	private Dictionary<int, MasterBattleSkillParam> dict = new Dictionary<int, MasterBattleSkillParam>();

	public MasterBattleSkillParam Get(int _iBattleSkillId)
	{
		MasterBattleSkillParam retParam = null;
		dict.TryGetValue(_iBattleSkillId, out retParam);
		return retParam;
	}

	private void SetupDict()
	{
		dict.Clear();
		foreach (MasterBattleSkillParam param in list)
		{
			dict.Add(param.battle_skill_id, param);
		}
	}

	protected override void afterRecievedSpreadSheet()
	{
		base.afterRecievedSpreadSheet();
		SetupDict();
	}

}
