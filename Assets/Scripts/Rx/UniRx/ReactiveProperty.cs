using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

public class ReactiveProperty : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var rp = new ReactiveProperty<int>(5);
		rp.Subscribe (x => Debug.Log(x));
		rp.Value = 10;
		rp.Value = 30;
	}
}
