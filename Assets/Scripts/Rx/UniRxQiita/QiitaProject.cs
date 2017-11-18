using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class QiitaProject : MonoBehaviour 
{
    //Subject作成
    Subject<string> subject = new Subject<string>();
    void Start()
    {


        //3回Subscribe
        subject.Subscribe(msg => Debug.Log("Subscribe1:" + msg));
        subject.Subscribe(msg => Debug.Log("Subscribe2:" + msg));
        subject.Subscribe(msg => Debug.Log("Subscribe3:" + msg));

        //イベントメッセージ発行
        subject.OnNext("こんにちは");
subject.OnNext("おはよう");
    }

    //void Update()
    //{
	
    //}
}
