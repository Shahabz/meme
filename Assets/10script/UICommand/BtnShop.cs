using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Button))]
public class BtnShop : MonoBehaviour {

	[SerializeField]
	private Text m_txtName;
	public UnityEvent OnClick = new UnityEvent();

	public string m_strPageKey;
	private Button m_btn = null;

	private int m_iRetryCount;

	public void Initialize( string _strKey)
	{
		m_iRetryCount = 0;

		if (m_btn == null)
		{
			m_btn = gameObject.GetComponent<Button>();
			m_btn.onClick.AddListener(() =>
			{
				if(m_strPageKey.Equals("") == false)
				{
					DataManager.Instance.showShop = m_strPageKey;
					UIAssistant.main.ShowPage(DataManager.Instance.PAGENAME_COMMAND_SHOP_TOP);
				}
				OnClick.Invoke();
			});
		}
		StartCoroutine(setText(_strKey));
	}

	private IEnumerator setText( string _strKey )
	{
		if( word.Instance.IsReady)
		{
			m_txtName.text = word.Instance.get(_strKey);
		}
		else if(m_iRetryCount < 5)
		{
			yield return new WaitForSeconds(0.5f);
			StartCoroutine(setText(_strKey));
		}
		else
		{
			;
		}
		yield return 0;
	}



	
}
