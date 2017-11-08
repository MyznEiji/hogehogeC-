using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass<T> : MonoBehaviour 
{   
    private int _top;
    private readonly T[] _mystack;

    public GenericClass(int max)
    {
        _mystack = new T[max];
        this._top = 0;
    }

    public void Push(T x)
    {
        this._mystack[this._top++] = x;
    }
    public T Pop()
    {
        return this._mystack[--this._top];
    }

    public void ShowStack()
    {
        for (var i = 0; i < _top; i++)
        {
            Debug.Log(_mystack[i]);
        }
    }

    void Start()
    {
        var genericClass1 = new GenericClass<int>(5); 
        var genericClass2 = new GenericClass<float>(5);
    }

    //void Update()
    //{
	
    //}
}
