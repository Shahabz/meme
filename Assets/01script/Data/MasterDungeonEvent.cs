using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterDungeonEventParam : CsvDataParam
{
	public int dungeon_event_id { get; set; }
	public string title { get; set; }

	public string type { get; set; }

	public int level { get; set; }
	public string description { get; set; }

}

public class MasterDungeonEvent : CsvData<MasterDungeonEventParam> {


}
