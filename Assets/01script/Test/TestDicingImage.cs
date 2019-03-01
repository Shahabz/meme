using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDicingImage : MonoBehaviour {

	public Utage.DicingImage dicing_image;

	public string assetbundle_name;
	public string asset_name;
	public string start_pattern;



	// Use this for initialization
	IEnumerator Start () {
		AssetBundleManager.Instance.Initialize("",0);

		Debug.Log("TestDicingImage.Start");

		yield return StartCoroutine(AssetBundleManager.Instance.LoadAssetBundle(assetbundle_name,
				(bool _bResult, string _strError) => {
					if(_bResult)
					{
						//masterChara.Load(AssetBundleManager.Instance.GetAsset<TextAsset>("master_data" , "master_chara.csv"));
						dicing_image.DicingData = AssetBundleManager.Instance.GetAsset<Utage.DicingTextures>(assetbundle_name, asset_name);

						dicing_image.ChangePattern(start_pattern);

						Debug.Log(AssetBundleManager.Instance.GetAsset<Utage.DicingTextures>("image/chara/anne" , "image/chara/anne.asset"));
						Debug.Log(AssetBundleManager.Instance.GetAsset<Utage.DicingTextures>("image/chara/anne" , "Assets/02texture/Dicing/Output1/Character/anne.asset"));
						Debug.Log(AssetBundleManager.Instance.GetAsset<Utage.DicingTextures>("image/chara/anne" , "anne.asset"));
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
