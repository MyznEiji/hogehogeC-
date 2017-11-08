using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;   

public class Generic : MonoBehaviour 
{
    private T Max<T>(T x,T y)where T : IComparable
    {
        if(x.CompareTo(y) > 0)
        {
            return x;
        }
        else 
        {
            return y;
        }
    }
    void Start()
    {
        var answer_int = Max<int>(3,5);
        print(answer_int);

        var answer_double = Max<double>(2.5, 5.2);
        print(answer_double);
    }

    //void Update()
    //{
	
    //}
}

