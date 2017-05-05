using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterCharaParam : CsvDataParam
{
	public int chara_id { get; set; }
	public string name { get; set; }
	public string filename { get; set; }
	public string sex { get; set; }     // 文字列で持たせるメリットある？

	public string profile { get; set; }

}

public class MasterChara : CsvData<MasterCharaParam> {
	private Dictionary<int, MasterCharaParam> dict = new Dictionary<int, MasterCharaParam>();
	public MasterCharaParam Get(int _charaId)
	{
		MasterCharaParam retParam = null;
		dict.TryGetValue(_charaId, out retParam);
		return retParam;
	}
	public void SetupDict()
	{
		dict.Clear();
		foreach (MasterCharaParam param in list)
		{
			//Debug.LogError(param.chara_id);
			dict.Add(param.chara_id, param);
		}
	}


	protected override void afterRecievedSpreadSheet()
	{
		base.afterRecievedSpreadSheet();
		SetupDict();
	}

}

