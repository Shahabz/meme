using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FooterButtonRoot : MonoBehaviour {
	private Vector2 positionTate = new Vector2(0.0f, 60.0f);
	private Vector2 positionYoko = new Vector2(0.0f,  5.0f);

	[SerializeField]
	private RectTransform m_rectTransform;
	[SerializeField]
	private HorizontalLayoutGroup m_horizontalLayoutGroup;

	[SerializeField]
	private List<RectTransform> m_btnList;
	
	void Start()
	{
		DeviceOrientationDetector.Instance.OnChangeOrientation.AddListener(OnChangeOrientation);
	}

	private void OnChangeOrientation( DeviceOrientationDetector.ORIENTATION _orientation)
	{
		if(_orientation == DeviceOrientationDetector.ORIENTATION.YOKO)
		{
			foreach (RectTransform rt in m_btnList)
			{
				rt.sizeDelta = new Vector2(65.0f, 65.0f);
			}
			m_rectTransform.anchoredPosition= positionYoko;
			m_horizontalLayoutGroup.childAlignment = TextAnchor.LowerRight;
			m_horizontalLayoutGroup.spacing = 0;
			//Debug.LogError(m_rectTransform.anchoredPosition);
			//Debug.LogError(m_rectTransform.anchoredPosition3D);


		}
		else
		{
			foreach (RectTransform rt in m_btnList)
			{
				rt.sizeDelta = new Vector2(85.0f, 85.0f);
			}
			m_rectTransform.anchoredPosition = positionTate;
			m_horizontalLayoutGroup.childAlignment = TextAnchor.MiddleCenter;
			m_horizontalLayoutGroup.spacing = 0;
		}
	}





}
