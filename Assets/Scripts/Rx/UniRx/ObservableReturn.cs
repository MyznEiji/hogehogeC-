using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ObservableReturn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Observable.Return(Unit.Default)
				.Subscribe
				(
					x => Debug.Log(x),
					() => Debug.Log("Completed")
				);
	}
}
