using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDungeonMain : CPanel
{

	[SerializeField]
	private Button m_btnForward;
	[SerializeField]
	private Button m_btnBack;
	[SerializeField]
	private Button m_btnTurnLeft;
	[SerializeField]
	private Button m_btnTurnRight;
	[SerializeField]
	private Button m_btnSlideLeft;
	[SerializeField]
	private Button m_btnSlideRight;

	public bool m_bForward;
	public bool m_bBack;
	public bool m_bSlideLeft;
	public bool m_bSlideRight;

	protected override void awake()
	{
		base.awake();
		DeviceOrientationDetector.Instance.OnChangeOrientation.AddListener(OnChangeOrientation);

	}

	protected override void panelStart()
	{
		base.panelStart();
		m_bForward = false;
		m_bBack = false;
		m_bSlideLeft = false;
		m_bSlideRight = false;
	}

	void Update()
	{
		if( m_bForward)
		{
			OnForward.Invoke(1.0f);
		}
		if (m_bBack)
		{
			OnForward.Invoke(-1.0f);
		}
		if (m_bSlideLeft)
		{
			OnSlide.Invoke(-1.0f);
		}
		if (m_bSlideRight)
		{
			OnSlide.Invoke( 1.0f);
		}

	}

	public UnityEventFloat OnForward = new UnityEventFloat();
	public UnityEventFloat OnSlide = new UnityEventFloat();

	public void OnRD_Forward()
	{
		m_bForward = true;
	}
	public void OnRU_Forward()
	{
		m_bForward = false;
	}
	public void OnRD_Back()
	{
		m_bBack = true;
	}
	public void OnRU_Back()
	{
		m_bBack = false;
	}

	public void OnRD_SlideLeft()
	{
		m_bSlideLeft = true;
	}
	public void OnRU_SlideLeft()
	{
		m_bSlideLeft = false;
	}
	public void OnRD_SlideRight()
	{
		m_bSlideRight = true;
	}
	public void OnRU_SlideRight()
	{
		m_bSlideRight = false;
	}


	private void OnChangeOrientation(DeviceOrientationDetector.ORIENTATION _orientation)
	{
		if (_orientation == DeviceOrientationDetector.ORIENTATION.YOKO)
		{
			RectTransform rtBtnLeft = m_btnTurnLeft.GetComponent<RectTransform>();
			//MonoBehaviourEx.CheckRectTransform(rtBtnLeft, "rtBtnLeft");
			rtBtnLeft.anchorMin = new Vector2(0, 0);
			rtBtnLeft.anchorMax = new Vector2(0, 0);
			rtBtnLeft.offsetMin = new Vector2(0, 0);
			rtBtnLeft.offsetMax = new Vector2(165, 100);
			rtBtnLeft.sizeDelta = new Vector2(165, 100);

			RectTransform rtBtnRight = m_btnTurnRight.GetComponent<RectTransform>();
			//MonoBehaviourEx.CheckRectTransform(rtBtnRight, "rtBtnRight");
			rtBtnRight.anchorMin = new Vector2(1, 0);
			rtBtnRight.anchorMax = new Vector2(1, 0);
			rtBtnRight.offsetMin = new Vector2(-165, 0);
			rtBtnRight.offsetMax = new Vector2(0, 100);
			rtBtnRight.sizeDelta = new Vector2(165, 100);

			RectTransform rtForward = m_btnForward.GetComponent<RectTransform>();
			//MonoBehaviourEx.CheckRectTransform(rtForward, "rtForward");
			rtForward.anchorMin = new Vector2(0, 0);
			rtForward.anchorMax = new Vector2(1, 1);
			rtForward.offsetMin = new Vector2(165, 100);
			rtForward.offsetMax = new Vector2(-165, -120);
			rtForward.sizeDelta = new Vector2(-330, -220);

			RectTransform rtBack = m_btnBack.GetComponent<RectTransform>();
			//MonoBehaviourEx.CheckRectTransform(rtBack, "rtBack");			
			rtBack.anchorMin = new Vector2(0, 0);
			rtBack.anchorMax = new Vector2(1, 0);
			rtBack.offsetMin = new Vector2(150, 0);
			rtBack.offsetMax = new Vector2(-150, 100);
			rtBack.sizeDelta = new Vector2(-300, 100);

			RectTransform rtSlideLeft = m_btnSlideLeft.GetComponent<RectTransform>();
			//MonoBehaviourEx.CheckRectTransform(rtSlideLeft, "rtSlideLeft");
			rtSlideLeft.anchorMin = new Vector2(0, 0);
			rtSlideLeft.anchorMax = new Vector2(0, 1);
			rtSlideLeft.offsetMin = new Vector2(0, 100);
			rtSlideLeft.offsetMax = new Vector2(165, -120);
			rtSlideLeft.sizeDelta = new Vector2(165, -220);

			RectTransform rtSlideRight = m_btnSlideRight.GetComponent<RectTransform>();
			//MonoBehaviourEx.CheckRectTransform(rtSlideRight, "rtSlideRight");
			rtSlideRight.anchorMin = new Vector2(1, 0);
			rtSlideRight.anchorMax = new Vector2(1, 1);
			rtSlideRight.offsetMin = new Vector2(-165, 100);
			rtSlideRight.offsetMax = new Vector2(0, -120);
			rtSlideRight.sizeDelta = new Vector2(165, -220);
		}
		else
		{
			//m_btnTurnLeft.transform.localPosition = new Vector3(0.0f , 65.0f , 0.0f );
			//m_btnTurnRight.transform = new Vector3(0.0f, 65.0f, 0.0f);

			RectTransform rt = m_btnTurnLeft.GetComponent<RectTransform>();
			rt.anchorMin = new Vector2(0, 0);
			rt.anchorMax = new Vector2(0, 0);
			rt.offsetMin = new Vector2(0, 65);
			rt.offsetMax = new Vector2(165, 165);
			rt.sizeDelta = new Vector2(165, 100);

			rt = m_btnTurnRight.GetComponent<RectTransform>();
			rt.anchorMin = new Vector2(1, 0);
			rt.anchorMax = new Vector2(1, 0);
			rt.offsetMin = new Vector2(-165, 65);
			rt.offsetMax = new Vector2(0, 165);
			rt.sizeDelta = new Vector2(165, 100);

			RectTransform rtForward = m_btnForward.GetComponent<RectTransform>();
			//MonoBehaviourEx.CheckRectTransform(rtForward, "rtForward");
			rtForward.anchorMin = new Vector2(0, 0);
			rtForward.anchorMax = new Vector2(1, 1);
			rtForward.offsetMin = new Vector2(165, 170);
			rtForward.offsetMax = new Vector2(-165, -150);
			rtForward.sizeDelta = new Vector2(-330, -320);

			RectTransform rtBack = m_btnBack.GetComponent<RectTransform>();
			//MonoBehaviourEx.CheckRectTransform(rtBack, "rtBack");
			rtBack.anchorMin = new Vector2(0, 0);
			rtBack.anchorMax = new Vector2(1, 0);
			rtBack.offsetMin = new Vector2(150, 65);
			rtBack.offsetMax = new Vector2(-150, 165);
			rtBack.sizeDelta = new Vector2(-300, 100);

			RectTransform rtSlideLeft = m_btnSlideLeft.GetComponent<RectTransform>();
			//MonoBehaviourEx.CheckRectTransform(rtSlideLeft, "rtSlideLeft");
			rtSlideLeft.anchorMin = new Vector2(0, 0);
			rtSlideLeft.anchorMax = new Vector2(0, 1);
			rtSlideLeft.offsetMin = new Vector2(0, 170);
			rtSlideLeft.offsetMax = new Vector2(165, -150);
			rtSlideLeft.sizeDelta = new Vector2(165, -320);

			RectTransform rtSlideRight = m_btnSlideRight.GetComponent<RectTransform>();
			//MonoBehaviourEx.CheckRectTransform(rtSlideRight, "rtSlideRight");
			rtSlideRight.anchorMin = new Vector2(1, 0);
			rtSlideRight.anchorMax = new Vector2(1, 1);
			rtSlideRight.offsetMin = new Vector2(-165, 170);
			rtSlideRight.offsetMax = new Vector2(0, -150);
			rtSlideRight.sizeDelta = new Vector2(165, -320);
		}
	}
}

