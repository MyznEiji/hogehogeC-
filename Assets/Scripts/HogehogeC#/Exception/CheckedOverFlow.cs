using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CheckedOverFlow : MonoBehaviour {
    private int x,y,z;
    void Start()
    {
        try
        {
            checked
            {
                x = int.MaxValue;
                y = 1;
                z = x + y;

                Debug.Log(x);
                Debug.Log(z);
            }
        }
        catch(OverflowException e)
        {
            Debug.Log(e.Message);
        }
    }

    //void Update()
    //{
	
    //}
}
