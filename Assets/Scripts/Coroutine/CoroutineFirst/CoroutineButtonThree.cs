using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System.Linq;

public class CoroutineButtonThree : MonoBehaviour {
	[SerializeField] private Button _button1;
	[SerializeField] private Button _button2;
	[SerializeField] private Button _button3;
	// Use this for initialization
	void Start () {
		StartCoroutine(WaitButtonClick(_button1,_button2,_button3));
	}
	IEnumerator WaitButtonClick(params Button[] buttons)
	{
		var y = buttons.Select(b => b.OnClickAsObservable().First().Select(_ => b))
					   .Aggregate((a,b) => a.Amb(b))
					   .ToYieldInstruction();
		yield return y;
		Debug.LogFormat("{0}がクリックされました",y.Result.name);
	}
}
