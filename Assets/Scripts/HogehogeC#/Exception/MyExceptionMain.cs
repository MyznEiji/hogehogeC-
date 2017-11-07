using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyExceptionMain : MonoBehaviour {
    [SerializeField] private int x = 0;
    void Start()
    {
        try
        {
            if(x == 0)
            {
                throw new MyException();
            }
            Debug.Log(10 / x);
        }
        catch(MyException e)
        {
            Debug.Log(e.Message);
            Debug.Log(e.ToString());
        }
    }
}
