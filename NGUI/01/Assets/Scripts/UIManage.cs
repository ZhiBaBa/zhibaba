using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManage : MonoBehaviour {

    private GameObject prefab_Info;
	void Start () {
        prefab_Info =Resources.Load<GameObject>("Info");

        NGUITools.AddChild(gameObject,prefab_Info);
	}

}
