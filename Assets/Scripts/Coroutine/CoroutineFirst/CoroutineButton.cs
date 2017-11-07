using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class CoroutineButton : MonoBehaviour {

	[SerializeField] private Button _button1;
	// Use this for initialization
	void Start () {
		StartCoroutine(WaitButtonClick(_button1));		
	}
	private IEnumerator WaitButtonClick(Button button)
	{
		yield return button.OnClickAsObservable()
						   .First()
						   .ToYieldInstruction();
		Debug.LogFormat("{0}がクリックされました",button.name);
	}
}
