using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonClickNotUniRx : MonoBehaviour {
	[SerializeField] private Button button;
	[SerializeField] private Text text;
	private int count = 0;
	// Use this for initialization
	void Start () {
		// button.onClick.AddListener
		// (
		// 	() => text.text = "Done"
		// );
		print("Buttonを2回クリックしてください");
		button.onClick.AddListener
		(
			() => 
			{
				count ++;
				if (count == 2)
				{
					text.text = "Now Loading";
					Invoke("TextChange",2.0f);
				}
			}
		);	
	}

	void TextChange()
	{
		text.text = "Done";
	}
}
