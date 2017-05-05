using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSize : Singleton<CanvasSize> {

	[SerializeField]
	private RectTransform rt;
	public override void Initialize()
	{
		base.Initialize();
		SetDontDestroy(false);
	}

	public float canvasWidth
	{
		get
		{
			return rt.sizeDelta.x;
		}
	}
	public float canvasHeight
	{
		get
		{
			return rt.sizeDelta.y;
		}
	}

}
