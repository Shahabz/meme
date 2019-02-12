using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDicingImage : MonoBehaviour {

	public Utage.DicingImage dicing_image;

	// Use this for initialization
	IEnumerator Start () {
		AssetBundleManager.Instance.Initialize("",0);

		Debug.Log("TestDicingImage.Start");

		yield return StartCoroutine(AssetBundleManager.Instance.LoadAssetBundle("image/chara/anneliese",
				(bool _bResult, string _strError) => {
					if(_bResult)
					{
						//masterChara.Load(AssetBundleManager.Instance.GetAsset<TextAsset>("master_data" , "master_chara.csv"));
						dicing_image.DicingData = AssetBundleManager.Instance.GetAsset<Utage.DicingTextures>("image/chara/anneliese" , "anneliese.asset");

						dicing_image.ChangePattern( "normal01_01");

						Debug.Log(AssetBundleManager.Instance.GetAsset<Utage.DicingTextures>("image/chara/anneliese" , "image/chara/anneliese.asset"));
						Debug.Log(AssetBundleManager.Instance.GetAsset<Utage.DicingTextures>("image/chara/anneliese" , "Assets/02texture/Dicing/Output1/Character/anneliese.asset"));
						Debug.Log(AssetBundleManager.Instance.GetAsset<Utage.DicingTextures>("image/chara/anneliese" , "anneliese.asset"));
					}
					else{
						Debug.Log("fail");
					}
				},(float progress, int fileNum, int fileIndex, bool isComplete, string error) =>
				{
				}));


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
