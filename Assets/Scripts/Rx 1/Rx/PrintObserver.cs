using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

public class PrintObserver : IObserver<int>
{
    public void OnNext(int value)
    {
        Debug.Log ("OnNext(" + value + ") called"); 
    }

    public void OnCompleted()
    {
        Debug.Log ("OnCompleted called");
    }

    public void OnError(Exception error)
    {
        Debug.Log ("OnError called");   
    }
}
