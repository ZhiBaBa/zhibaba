using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 用代码动态创建UISprite UI物体
/// </summary>
public class SpriteTest : MonoBehaviour {
    private Transform m_transform;
    private Transform Box_transform;
	
	void Start ()
    {
        //获取UI Root的Transform组件
        m_transform = gameObject.GetComponent<Transform>();
        //实例化一个go对象
        GameObject uiSprite = new GameObject("huangzhiquan");
        //将UISprite设置为UI Root 的子类
        uiSprite.GetComponent<Transform>().SetParent(m_transform);
        //重置Scale
        uiSprite.GetComponent<Transform>().localScale = Vector3.one;
        //动态给uiSprite添加一个UISprite组件
        UISprite Sprite  =  uiSprite.AddComponent<UISprite>();

        //读取图集
        UIAtlas atlas = Resources.Load<UIAtlas>("game_Atlas");
        //指定图集
        Sprite.atlas = atlas;
        //给组件指定图片
        Sprite.spriteName = "11000414";

       // Box_transform = GameObject.Find("Box").GetComponent<Transform>();
       //定义一个新的位置
        Vector3 postion = new Vector3(-10,-1,0);
        Sprite.GetComponent<Transform>().localPosition = postion;

	}
	
	
	void Update () {
		
	}
}
