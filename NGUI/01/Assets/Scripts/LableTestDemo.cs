using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LableTestDemo : MonoBehaviour {

    private UILabel goldNumber;
    private UILabel lable;
	void Start () {
        goldNumber = GameObject.Find("gold_Number").GetComponent<UILabel>();
        lable = GameObject.Find("Label").GetComponent<UILabel>();
        goldNumber.text = "1234";
        lable.text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\naaaaaaaaaaaaaaaaaaaaa";
	}
	
	
	void Update () {
		
	}
}
