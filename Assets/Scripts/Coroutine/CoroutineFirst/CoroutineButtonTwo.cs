using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class CoroutineButtonTwo : MonoBehaviour {
	[SerializeField] private Button _button1;
	[SerializeField] private Button _button2;
	// Use this for initialization
	void Start () {
		StartCoroutine(WaitButtonClick(_button1,_button2));	
	}

	IEnumerator WaitButtonClick(Button button1,Button button2)
	{
		var a = button1.OnClickAsObservable()
					   .First()
					   .Select(_ => button1);
		var b = button2.OnClickAsObservable()
					   .First()
					   .Select(_ => button2);
		var y = a.Amb(b).ToYieldInstruction();
		yield return y;
		Debug.LogFormat("{0}がクリックされました",y.Result.name);
	}
}
