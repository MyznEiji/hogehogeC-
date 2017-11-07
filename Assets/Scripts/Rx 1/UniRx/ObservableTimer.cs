using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class ObservableTimer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Observable.Timer(TimeSpan.FromSeconds(2))
			.Subscribe(_ => Debug.Log("2秒後"));
		
		Observable.Timer(TimeSpan.FromSeconds(1),TimeSpan.FromSeconds(1))
			.Subscribe(_ => Debug.Log("1秒毎"));
	}
}
