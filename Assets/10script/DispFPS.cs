using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class DispFPS : MonoBehaviour {

	float m_fTime;
	int m_iCount;
	private Text m_textFps;
	void Start () {
		m_textFps = gameObject.GetComponent<Text>();
		m_fTime = 0.0f;
		m_iCount = 0;
	}
	
	// Update is called once per frame
	void Update () {

		m_iCount += 1;
		m_fTime += Time.deltaTime;

		if( 1.0f < m_fTime)
		{
			string debug = string.Format("FPS:{0}", m_iCount / m_fTime);
			m_textFps.text = debug;
			Debug.LogError(debug);

			m_iCount = 0;
			m_fTime -= 1.0f;
		}
		
	}
}
