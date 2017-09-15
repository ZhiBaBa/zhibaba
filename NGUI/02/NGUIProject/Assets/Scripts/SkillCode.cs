using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCode : MonoBehaviour {

    private float CodeTime = 5; //冷却时间
    private UISprite sprite;

    private bool IsCoding = false;
	void Start () {
       // sprite = GameObject.Find("Sprite").GetComponent<UISprite>();
	}
    private void Awake()
    {
       sprite = transform.Find("Sprite").GetComponent<UISprite>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.A) && IsCoding == false)
        {
            //可以释放技能
            IsCoding = true;
            sprite.fillAmount = 1;
        }
        if (IsCoding == true)
        {
            sprite.fillAmount -= 1f /CodeTime  * Time.deltaTime;
            if (sprite.fillAmount <= 0.05)
            {
                IsCoding = false;
                sprite.fillAmount = 0;
            }
        }
	}
}
