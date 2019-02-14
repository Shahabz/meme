using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataItemParam : CsvDataParam
{
	public int item_id { get; set; }
	public int num { get; set; }
}

public class DataItem : CsvData<DataItemParam> {

	public const string FILENAME = "data/item";
	public DataItem()
	{
		if( Load(FILENAME) == false)
		{
			Save(FILENAME);
		}
	}


}
