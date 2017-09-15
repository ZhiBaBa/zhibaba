using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextList : MonoBehaviour {
    private UITextList _TextList;
    private int Number = 0;
	// Use this for initialization
	void Start () {
        _TextList = this.GetComponent<UITextList>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            _TextList.Add("huangzhiquan" + Number++);
        }
	}
}
