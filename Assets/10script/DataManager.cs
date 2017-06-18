using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EveryStudioLibrary;

public class DataManager : DataManagerBase<DataManager> {

	public string selectedLanguage = "ja";

	public readonly string CONFIG_SPREAD_SHEET = "1smJagyFSX9ybvNyD5AG-gNblK6JMdkqyhLuCwm1DAug";
	public readonly string SPREAD_SHEET_SHEET_ID_CHARA = "ogg4zb9";
	public readonly string SPREAD_SHEET_SHEET_ID_EQUIP = "olud92k";
	public readonly string SPREAD_SHEET_SHEET_ID_EQUIP_TYPE = "oihzol";
	public readonly string SPREAD_SHEET_SHEET_ID_ITEM = "og370ot";
	public readonly string SPREAD_SHEET_SHEET_ID_NOTICE = "oxdluzv";
	public readonly string SPREAD_SHEET_SHEET_ID_JOB = "oaj2kg8";
	public readonly string SPREAD_SHEET_SHEET_ID_MISSION = "odqgmhv";
	public readonly string SPREAD_SHEET_SHEET_ID_EQUIP_SKILL = "op4kw0b";
	public readonly string SPREAD_SHEET_SHEET_ID_BATTLE_SKILL = "otm2e00";

	#region ページ名
	public readonly string PAGENAME_COMMAND_MAIN = "1_3main";
	public readonly string PAGENAME_COMMAND_SHOP_TOP = "shop_top";

	#endregion

	public MasterChara masterChara = null;
	public MasterItem masterItem = null;
	public MasterNotice masterNotice = null;
	public MasterEquip masterEquip = null;
	public MasterEquipType masterEquipType = null;
	public MasterMission masterMission = null;
	public MasterEquipSkill masterEquipSkill = null;
	public MasterBattleSkill masterBattleSkill = null;

	public override void Initialize()
	{
		Application.targetFrameRate = 60;
		SetDontDestroy(true);
		base.Initialize();
		masterChara = new MasterChara();
		masterChara.LoadSpreadSheet(CONFIG_SPREAD_SHEET, SPREAD_SHEET_SHEET_ID_CHARA);
		masterItem = new MasterItem();
		masterItem.LoadSpreadSheet(CONFIG_SPREAD_SHEET, SPREAD_SHEET_SHEET_ID_ITEM);
		masterNotice = new MasterNotice();
		masterNotice.LoadSpreadSheet(CONFIG_SPREAD_SHEET, SPREAD_SHEET_SHEET_ID_NOTICE);
		masterEquip = new MasterEquip();
		masterEquip.LoadSpreadSheet(CONFIG_SPREAD_SHEET, SPREAD_SHEET_SHEET_ID_EQUIP);
		masterEquipType = new MasterEquipType();
		masterEquipType.LoadSpreadSheet(CONFIG_SPREAD_SHEET, SPREAD_SHEET_SHEET_ID_EQUIP_TYPE);
		masterMission = new MasterMission();
		masterMission.LoadSpreadSheet(CONFIG_SPREAD_SHEET, SPREAD_SHEET_SHEET_ID_MISSION);
		masterEquipSkill = new MasterEquipSkill();
		masterEquipSkill.LoadSpreadSheet(CONFIG_SPREAD_SHEET, SPREAD_SHEET_SHEET_ID_EQUIP_SKILL);
		masterBattleSkill = new MasterBattleSkill();
		masterBattleSkill.LoadSpreadSheet(CONFIG_SPREAD_SHEET, SPREAD_SHEET_SHEET_ID_BATTLE_SKILL);
		
		dataItem = new DataItem();
		dataChara = new DataChara();
		dataEquip = new DataEquip();
		dataMission = new DataMission();
		dataEquipSkill = new DataEquipSkill();
		dataBattleSkill = new DataBattleSkill();
	}
	public DataItem dataItem;
	public DataChara dataChara;
	public DataEquip dataEquip;
	public DataMission dataMission;
	public DataEquipSkill dataEquipSkill;
	public DataBattleSkill dataBattleSkill;

	// 連絡用
	public DataCharaParam selectedDataCharaParam { get; set; }
	public string showShop { get; set; }

	public Text m_debugPrint;
	public Text m_debugPrint2;
	public SkitRoot skitroot;
	void Update()
	{
		/*
		m_debugPrint.text = skitroot.SkitCanvasHeightOriginal.ToString();
		m_debugPrint2.text = skitroot.SkitCanvasHeightMax.ToString();
		*/
	}

}


