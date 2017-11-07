using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

public class Model2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var source = new NumberObservable();
		//var subscribe1 = source.Subscribe(new PrintObserver());
        var subscribe1 = source.Subscribe 
		(
            value => Debug.Log("OnNext(" + value + ") called"),
			ex => Debug.Log ("OnError called"),
			() => Debug.Log ("OnCompleted called")
		);

		//var subscribe2 = source.Subscribe(new PrintObserver());
		var subscribe2 = source.Subscribe
		(
            value => Debug.Log ("OnNext(" + value + ") called"),
            ex => Debug.Log ("OnError called"),
            () => Debug.Log ("OnCompleted called")
		);

		Debug.Log("# Execute1");
		source.Execute(1);

		Debug.Log("# Dispose");
		subscribe2.Dispose();

		Debug.Log("# Execute2");
		source.Execute(2);

		Debug.Log("# Execute0");
		source.Execute(0);

		//var subscribe3 = source.Subscribe(new PrintObserver());
		var subscribe3 = source.Subscribe
		(
			value => Debug.Log ("OnNext(" + value + ") called"),
            ex => Debug.Log ("OnError called"),
            () => Debug.Log ("OnCompleted called")
		);
		Debug.Log("# Completed");
		source.Completed();	
	}
}
