using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;
using UniRx.Triggers;

public class CoroutineStream : MonoBehaviour
{
    void Start ()
    {
        Observable.FromCoroutine<long> (observer => CountCoroutine (observer))
            .Subscribe (x => Debug.Log(x));
    }

    IEnumerator CountCoroutine(IObserver<long> observer)
    {
        long current = 0;
        float deltaTime = 0;
        bool isPause;

        while (true)
        {
            isPause = Input.GetKey (KeyCode.Space);
            if (!isPause) 
            {
                deltaTime += Time.deltaTime;
                if (deltaTime >= 1.0f)
                {
                    var integerPart = (int)Mathf.Floor (deltaTime);
                    current += integerPart;
                    deltaTime -= integerPart;

                    observer.OnNext (current);
                }
            }
            yield return null;
        }
    }
}
