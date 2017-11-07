using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class FlyweightTestUsed : MonoBehaviour {
	// Use this for initialization

	string[] ary = new string[] { "b", "aaaaa", "cc" };
	private bool IsLengthOne(string str)
	{
	return str.Length == 1;
	}


	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
    //文字列の長さが1の要素を検索
    if (ary.Any(ary => ary.Length == 1))
    {
        Debug.Log("長さが1の要素が見つかりました。");
    }
	
	}
}
