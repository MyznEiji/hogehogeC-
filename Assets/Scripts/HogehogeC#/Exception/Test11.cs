using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test11 : MonoBehaviour {

    void Start()
    {
        var list = new List<string>();
        try 
        {
            Debug.Log(list[0]);
        }
        catch(ArgumentOutOfRangeException e)
        {
            Debug.Log(e.Message);
        }
        finally
        {
            Debug.Log("called finally");
        }
    }

    //void Update()
    //{
	
    //}
}
