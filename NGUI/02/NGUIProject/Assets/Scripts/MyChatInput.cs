using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyChatInput : MonoBehaviour {
    private UIInput Chat_Input;
    public UITextList textlist;

    private string[] namess =new string[5] { "志霸霸", "小红", "小明", "小猪","小花" };
        
	void Awake () {
        Chat_Input = gameObject.GetComponent<UIInput>();
	}
	
    public void OnChatSubmit()
    {
        string ChatMassage = Chat_Input.value;
        string inputname = namess[Random.Range(0, 5)];
        textlist.Add(inputname+" : "+ChatMassage);
        Chat_Input.value = "";
    }
}
