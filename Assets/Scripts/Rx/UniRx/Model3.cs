using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

public class Model3 : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		var source = new NumberObservable();

		var subscribe1 = source
			// .Where(x => x % 2 == 0)
			// .Select(_ => 2)
			.Buffer(4,2)
			.Subscribe
			(
				value => Debug.Log("OnNext(" + value + ") called"),
				ex => Debug.Log("OnError called"),
				() => Debug.Log("OnCompleted called")
			);
		Debug.Log("## Execute1");
		source.Execute(1);

		Debug.Log("## Execute2");
		source.Execute(2);

		Debug.Log("## Execute3");
		source.Execute(3);

		Debug.Log("## Execute4");
		source.Execute(4);
	}
}
