using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;


public class UniRxFirst : MonoBehaviour {
	Subject<string> subject = new Subject<string>();
	// Use this for initialization
	void Start () {
		subject.Where(x => x == "そうめん")
			   .Subscribe(x => Debug.Log(x + "きたよ"));
		
		subject.OnNext("ラーメン");
		subject.OnNext("そば");
		subject.OnNext("そうめん");
		subject.OnNext("冷麺");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
