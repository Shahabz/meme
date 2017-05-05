using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class BannerDungeon : MonoBehaviour {

	[SerializeField]
	private Button m_btn;

	[SerializeField]
	private Image m_imgIcon;

	[SerializeField]
	private Text m_txtName;

	public void Initialize(int _iDungeonNo)
	{
		m_btn = gameObject.GetComponent<Button>();
		m_btn.onClick.AddListener(OnSelect);
	}

	private void OnSelect()
	{
		SkitConnector.Instance.root.OnSkitFinished.AddListener(OnSkitFinished);
		SkitConnector.Instance.root.Initialize("1MeYvualTlwUmGrO9Wx9CcWlQCCTZ3aVxmZa1Gm33O_A", "oc91q9y", "test_dungeon_start");
	}
	private void OnSkitFinished()
	{
		SkitConnector.Instance.root.OnSkitFinished.RemoveListener(OnSkitFinished);
		AdsManager.Instance.ShowBanner(false);
		SceneManager.LoadSceneAsync("Dungeon");		
	}


}
