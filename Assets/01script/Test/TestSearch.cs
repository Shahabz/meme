using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSearch : MonoBehaviour {

	public Test t;

	// Use this for initialization
	void Start () {
		Test instance = GameObject.FindObjectOfType(typeof(Test)) as Test;

		Debug.Log(instance);

		t = instance;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
