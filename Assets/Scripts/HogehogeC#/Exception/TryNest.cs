using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TryNest : MonoBehaviour {

    void Start()
    {
        int x = 10;
        int y = 0;

        try 
        {
            try
            {
                Debug.Log(x / y);
            }
            catch(IndexOutOfRangeException i)
            {
                Debug.Log(i.Message);
            }
        }
        catch(DivideByZeroException d)
        {
            Debug.Log(d.Message);
        }
    }

    //void Update()
    //{
	
    //}
}
