using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterEquipTypeParam : CsvDataParam
{
	public int equip_type { get; set; }
	public string name { get; set; }
	public string description { get; set; }

	public string name_ja { get; set; }
	public string description_ja { get; set; }
	public string name_en { get; set; }
	public string description_en { get; set; }
	public string name_cn { get; set; }
	public string description_cn { get; set; }
	public string name_kr { get; set; }
	public string description_kr { get; set; }
	public string name_th { get; set; }
	public string description_th { get; set; }
	public string name_RU { get; set; }
	public string description_RU { get; set; }
	public string name_DE { get; set; }
	public string description_DE { get; set; }
	public string name_FR { get; set; }
	public string description_FR { get; set; }
}

public class MasterEquipType : CsvData<MasterEquipTypeParam> {
	public const string SPREAD_SHEET_PAGE = "14NT9a0VRO4xSK2SEupSxg4_fqoSMNoD1U69BKF228CM";
	public const string SPREAD_SHEET_ID = "o7iw3n7";
}
