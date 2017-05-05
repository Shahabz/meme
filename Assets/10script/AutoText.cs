using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoText : MonoBehaviour {

	[SerializeField]
	private Text m_txt;

	[SerializeField]
	private string m_wordKey;

	private int m_iRetryCount;

	private const float INTERVAL = 1.0f;

	public void OnChangeLanguage()
	{
		if (m_wordKey.Equals("") == false) {
			Set(m_wordKey);
		}
	}

	void Start () {
		if(m_txt == null)
		{
			m_txt = gameObject.GetComponent<Text>();
		}
		if (0 < m_wordKey.Length)
		{
			Set(m_wordKey);
		}
		LanguageManager.Instance.OnChangeLanuguage.AddListener(OnChangeLanguage);
	}

	public void Set(string _strKey)
	{
		if (m_txt != null)
		{
			m_iRetryCount = 0;
			StartCoroutine(setText(_strKey));
		}
	}

	private IEnumerator setText(string _strKey)
	{
		if (word.Instance.IsReady)
		{
			m_txt.text = word.Instance.get(_strKey);
			m_wordKey = _strKey;
		}
		else if (m_iRetryCount < 5)
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


	// Update is called once per frame
	void Update () {
		
	}
}
