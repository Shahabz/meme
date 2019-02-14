using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterMissionParam : CsvDataParam
{
	public int mission_id { get; set; }
	public string title { get; set; }
	public string type { get; set; }
	public string type_option1 { get; set; }
	public string type_option2 { get; set; }
	public string open { get; set; }
	public string open_option1 { get; set; }
	public string open_option2 { get; set; }
	public string prize { get; set; }
	public string prize_option1 { get; set; }
	public string prize_option2 { get; set; }

}

public class MasterMission : CsvData<MasterMissionParam> {
	private Dictionary<int, MasterMissionParam> dict = new Dictionary<int, MasterMissionParam>();
	public MasterMissionParam Get(int _missionId)
	{
		MasterMissionParam retParam = null;
		dict.TryGetValue(_missionId, out retParam);
		return retParam;
	}
	public void SetupDict()
	{
		dict.Clear();
		foreach (MasterMissionParam param in list)
		{
			//Debug.LogError(param.chara_id);
			dict.Add(param.mission_id, param);
		}
	}

	protected override void afterRecievedSpreadSheet()
	{
		base.afterRecievedSpreadSheet();
		SetupDict();
	}

}
