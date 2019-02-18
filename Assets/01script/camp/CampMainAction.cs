using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using HutongGames.PlayMaker;

namespace CampMainAction {

	public class CampMainActionBase : FsmStateAction
	{
		protected CampMain campMain;
		public override void OnEnter()
		{
			base.OnEnter();
			campMain = Owner.GetComponent<CampMain>();
		}
	}
	[ActionCategory("CampMainAction")]
	[HutongGames.PlayMaker.Tooltip("CampMainAction")]
	public class Sample : CampMainActionBase{
		
	}



}
