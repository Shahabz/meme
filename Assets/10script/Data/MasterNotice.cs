using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterNoticeParam : CsvDataParam
{
	public int notice_id { get; set; }
	public int notice_type { get; set; }
	public string notice_icon { get; set; }
	public string date_start { get; set; }
	public string date_end { get; set; }
	public string title { get; set; }
	public string detail_mini { get; set; }
	public string detail_long { get; set; }

}

public class MasterNotice : CsvData<MasterNoticeParam> {
}
