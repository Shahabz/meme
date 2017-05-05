using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LanguageManager : Singleton<LanguageManager> {

	public string language
	{
		get
		{
			return m_strLanguage;
		}
		set
		{
			m_strLanguage = value;
			if(m_strLanguage.Equals(m_strLanguagePre) == false)
			{
				m_strLanguagePre = m_strLanguage;
				OnChangeLanuguage.Invoke();
			}
		}
	}

	public override void Initialize()
	{
		base.Initialize();
		SetDontDestroy(true);
	}
	[SerializeField]
	private string m_strLanguage = "ja";
	private string m_strLanguagePre = "ja";

	public UnityEvent OnChangeLanuguage = new UnityEvent();

}
