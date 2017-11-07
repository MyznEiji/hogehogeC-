using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using System;

public class ButtonClickUniRx : MonoBehaviour {
	[SerializeField] private Button button;
	[SerializeField] private Text text;
	// Use this for initialization
	void Start () 
	{
		// button.OnClickAsObservable()
		// 	  .Subscribe
		// 	  (
		// 		  _ => text.text = "Done"
		// 	  )	;

		button.OnClickAsObservable()
			.Buffer(2)
			.Do(_ => text.text = "Now Loading")
			.Delay(TimeSpan.FromMilliseconds(3000))
			.Subscribe (_ => text.text = "Done");
	}
}
