using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GenericDictionary : MonoBehaviour 
{

    void Start()
    {
        Dictionary<string,int> dict = new Dictionary<string, int>();

        dict["matsuda"] = 16;
        dict["sakamoto"] = 72;
        dict["takuma"] = 42;

        //格納されてる要素数を取得
        print("Count = " + dict.Count);
        print("masuda = " + dict["matsuda"]);
        print("sakamoto =" + dict["sakamoto"]);
    }

    //void Update()
    //{
	
    //}
}
