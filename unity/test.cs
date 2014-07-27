using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using avatar;

public class DynamicCreateUIAsset : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		Texture2D textrue = AvatarAssetManager.s.getTexture("skin/cloth/1");
		Shader shader = Shader.Find("Unlit/Transparent Colored");
		Material mat = new Material(shader);
		mat.mainTexture = textrue;
		UISpriteData uiSpData = new UISpriteData();
		uiSpData.width = textrue.width;
		uiSpData.height = textrue.height;
		UIAtlas atlas = gameObject.AddComponent<UIAtlas>();
		atlas.spriteMaterial = mat;
		List<UISpriteData> list = new List<UISpriteData>();
		list.Add(uiSpData);
		atlas.spriteList = list;

		UISprite sp = gameObject.AddComponent<UISprite>();
		sp.atlas = atlas;
		sp.MakePixelPerfect();

	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
}

