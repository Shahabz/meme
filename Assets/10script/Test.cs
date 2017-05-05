using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Image img = gameObject.GetComponent<Image>();
		Debug.LogError(gameObject.GetComponent<Image>().rectTransform.sizeDelta.x);
		Debug.LogError(gameObject.GetComponent<Image>().rectTransform.sizeDelta.y);

		float width = CanvasSize.Instance.canvasHeight * 640.0f / 1136.0f;
		img.rectTransform.sizeDelta = new Vector2(width, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
