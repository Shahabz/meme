using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class BtnBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Button>().onClick.AddListener(() =>
		{
			//Debug.LogError("push back");
			UIAssistant.main.ShowPreviousPage();
		});

	}
	
}
