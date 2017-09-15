using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knapsack : MonoBehaviour {

    public GameObject[] cases;           //定义一个背包数组
    public string[] equipmentName;      //定义装备名字

    public GameObject Item;             //创建一个预制体对象

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            PickUp();
        }
    }
    /// <summary>
    /// 捡起一件装备的方法
    /// </summary>
    public void PickUp()
    {
        int Index = Random.Range(0, equipmentName.Length);    //定义一个随机数
        string name = equipmentName[Index];                 //将捡起来的装备名字赋给字段
        bool isFind = false;
        for (int i = 0; i < cases.Length; i++)
        {    
            if (cases[i].transform.childCount > 0)//判断背包格子里是否有子物体
            {//如果有就获取格子中的子物体身上的MyDragAndDrop组件
                MyDragAndDrop item = cases[i].GetComponentInChildren<MyDragAndDrop>();   //重新定义一个MyDragAndDrop对象
                if (item.Sprite.spriteName == name)  //如果捡起来的装备名字等于格子中的装备名字
                {
                    isFind = true; 
                    item.AddCount(1);  
                    break;
                }
            }
        }

        if (isFind == false)
        {
            for (int i = 0; i < cases.Length; i++)
            {
                if (cases[i].transform.childCount == 0)  //如果格子中没有装备
                {
                    GameObject go = NGUITools.AddChild(cases[i], Item); //就重新实例化一个装备
                    go.GetComponent<UISprite>().spriteName = name;     //实例化的装备的名字就是捡起装备的名字
                    go.transform.localPosition = Vector3.zero;          //位置归零
                    break;
                }

            }
        }
    }
}
