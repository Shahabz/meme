using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EveryStudioLibrary;

public class word : Singleton<word> {

	public bool IsReady { get; set; }

	public readonly string SPREAD_SHEET = "1JyQ6nQMKg4f533SKkvhnd151TwiAWMTIJ0jt9E94n-k";
	public readonly string SPREAD_SHEET_CONFIG_SHEET = "od6";

	public CsvWord csvWord;
	public string get(string _strKey)
	{
		if (csvWord != null)
		{
			return csvWord.Get(_strKey, LanguageManager.Instance.language);
		}
		return "";
	}

	public override void Initialize()
	{
		IsReady = false;
		SetDontDestroy(true);
		base.Initialize();
		CommonNetwork.Instance.RecieveSpreadSheet(SPREAD_SHEET, SPREAD_SHEET_CONFIG_SHEET, onRecieved);
	}

	public void onRecieved(TNetworkData _data)
	{
		csvWord = new CsvWord();
		csvWord.Input(SpreadSheetData.ConvertSpreadSheetData(_data.m_dictRecievedData));
		csvWord.setupDict();
		/*
		Debug.LogError(string.Format("key:{0} word:{1}", "title" ,csvWord.Get("title", "ja")));
		Debug.LogError(string.Format("key:{0} word:{1}", "title", csvWord.Get("title", "en")));
		*/
		IsReady = true;
	}


}
