using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterItemParam : CsvDataParam
{
	public int item_id { get; set; }
	public string item_name { get; set; }
	public string item_description { get; set; }
	public string filename { get; set; }
	public string item_type { get; set; }
	public string item_category { get; set; }
	public float param1 { get; set; }
	public float param2 { get; set; }

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

public class MasterItem : CsvData<MasterItemParam> {

	private Dictionary<int, MasterItemParam> dict = new Dictionary<int, MasterItemParam>();

	protected override void afterRecievedSpreadSheet()
	{
		base.afterRecievedSpreadSheet();
		SetupDict();
	}

	public MasterItemParam Get(int _itemId)
	{
		MasterItemParam retParam = null;
		dict.TryGetValue(_itemId, out retParam);
		return retParam;
	}
	public void SetupDict()
	{
		dict.Clear();
		foreach( MasterItemParam param in list)
		{
			dict.Add(param.item_id, param);
		}
	}

	override protected MasterItemParam makeParam(List<SpreadSheetData> _list, int _iSerial, int _iRow)
	{
		int iIndex = 1;
		SpreadSheetData dataItemId = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataItemName = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataItemDescription = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataFilename = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataItemType = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataItemCategory = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataParam1 = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataParam2 = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataJaName = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataJaDescription = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataEnName = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataEnDescription = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataCnName = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataCnDescription = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataKrName = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataKrDescription = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataThName = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataThDescription = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataRUName = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataRUDescription = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataDEName = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataDEDescription = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataFRName = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataFRDescription = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);

		MasterItemParam retParam = new MasterItemParam();
		//Debug.LogError(dataKey.param);
		retParam.item_id = int.Parse(dataItemId.param);
		retParam.item_name = dataItemName.param;
		retParam.item_description = dataItemDescription.param ;
		retParam.filename = dataFilename.param ;
		retParam.item_type = dataItemType.param;
		retParam.item_category = dataItemCategory.param;
		retParam.param1 = float.Parse(dataParam1.param);
		retParam.param2 = float.Parse(dataParam2.param);

		retParam.name_ja = dataJaName.param;
		retParam.description_ja = dataJaDescription.param;
		retParam.name_en = dataEnName.param;
		retParam.description_en = dataEnDescription.param;
		retParam.name_cn = dataCnName.param;
		retParam.description_cn = dataCnDescription.param;
		retParam.name_kr = dataKrName.param;
		retParam.description_kr = dataKrDescription.param;
		retParam.name_th = dataThName.param;
		retParam.description_th = dataThDescription.param;
		retParam.name_RU = dataRUName.param;
		retParam.description_RU = dataRUDescription.param;
		retParam.name_DE = dataDEName.param;
		retParam.description_DE = dataDEDescription.param;
		retParam.name_FR = dataFRName.param;
		retParam.description_FR = dataFRDescription.param;
		return retParam;
	}


}




