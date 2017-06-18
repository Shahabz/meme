using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ミッションって言ってるけどクエストもね

public class DataMissionParam : CsvDataParam
{
	public int mission_id { get; set; }
	public int test { get; set; }
}

public class DataMission : CsvData<DataMissionParam> {

	public const string FILENAME = "data/mission";
	public DataMission()
	{
		if (Load(FILENAME) == false)
		{
			Save(FILENAME);
		}
	}

}
