using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterEquipSkillParam : CsvDataParam
{
	public int equip_skill_id { get; set; }
	public int equip_type { get; set; }
	public string name { get; set; }
	public int range_min { get; set; }
	public int range_max { get; set; }
	public string math { get; set; }
}

public class MasterEquipSkill : CsvData<MasterEquipSkillParam> {

	private Dictionary<int, MasterEquipSkillParam> dict = new Dictionary<int, MasterEquipSkillParam>();
	public MasterEquipSkillParam Get(int _equipSkillId)
	{
		MasterEquipSkillParam retParam = null;
		dict.TryGetValue(_equipSkillId, out retParam);
		return retParam;
	}
	public void SetupDict()
	{
		dict.Clear();
		foreach (MasterEquipSkillParam param in list)
		{
			//Debug.LogError(param.chara_id);
			dict.Add(param.equip_skill_id, param);
		}
	}
	public string GetName(int _equipSkillId)
	{
		MasterEquipSkillParam param = Get(_equipSkillId);
		if (param != null)
		{
			return param.name;
		}
		return "";
	}


	protected override void afterRecievedSpreadSheet()
	{
		base.afterRecievedSpreadSheet();
		SetupDict();
	}

}
