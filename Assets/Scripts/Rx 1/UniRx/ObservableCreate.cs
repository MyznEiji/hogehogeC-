using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ObservableCreate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Observable.Create<int>
		(
			observer => 
			{
				for (var i = 0; i <= 10; i++)
				{
					if(i % 2 == 0) observer.OnNext(i);
				}

				observer.OnCompleted();
				return Disposable.Create
				(
					() =>
					{
						Debug.Log("Dispose");
					} 
				);
			}
		).Subscribe(x => Debug.Log(x));
	}
}
