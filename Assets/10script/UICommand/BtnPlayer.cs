using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class BtnPlayer : MonoBehaviour {

	private bool m_bIsOpen = false;

	[SerializeField]
	private RectTransform m_rtSubmenuRoot;

	private Button m_btn;

	/*
	private string[] m_strPlayerBtnKeyArr = new string[]
	{
		"item",
		"notice",
		"present",
	};
	*/

	[SerializeField]
	private float m_fButtonMoveTime = 0.2f;

	private float m_fBtnHeight = 60.0f;

	public void Close()
	{
		if(m_bIsOpen == true)
		{
			OnClick();
		}
	}

	private void OnClick()
	{
		m_bIsOpen = !m_bIsOpen;
		float targetY = 0.0f;
		if (m_bIsOpen)
		{
			targetY = 0.0f;
		}
		else {
			targetY = m_fBtnHeight;
		}
		iTween.MoveTo(m_rtSubmenuRoot.gameObject, iTween.Hash("islocal" , true , "y", targetY, "easeType", "easeInOutExpo","time", m_fButtonMoveTime));
		return;
	}

	void Start () {
		m_btn = gameObject.GetComponent<Button>();
		m_bIsOpen = false;
		m_fBtnHeight = m_rtSubmenuRoot.rect.height;

		m_rtSubmenuRoot.localPosition = new Vector3(0.0f, m_fBtnHeight, 0.0f);
		m_btn.onClick.AddListener(OnClick);

	}

	// Update is called once per frame
	void Update () {
		
	}
}
