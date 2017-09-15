using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDragAndDrop:UIDragDropItem{

    public UISprite Sprite;
    public UILabel Label;
    private int count = 1;
    /// <summary>
    /// 装备数量增加
    /// </summary>
    /// <param name="number"></param>
    public void AddCount(int number)
    {
        count += number;
        Label.text = count + "";
    }
    /// <summary>
    /// 重写OnDragDropRelease方法
    /// </summary>
    /// <param name="surface"></param>
    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);
        print(surface.tag); //打印出释放后检测到的物体标签


        if (surface.tag == "Case")
        {
            gameObject.transform.parent = surface.transform;
            this.transform.localPosition = Vector3.zero; //gameObject 与this 意义相同
        }
        else if (surface.tag == "Item") //如果检测到格子里有物体 就进行交换
        {
            print(surface.tag);
            Transform Parent = surface.transform.parent;  //定义一个Transform对象 将检测到的对象的父类给该对象
            surface.transform.parent = this.transform.parent;
            surface.transform.localPosition = Vector3.zero;

            this.transform.parent = Parent;
            this.transform.localPosition = Vector3.zero;
            
        }

    }


}
