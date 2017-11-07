using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class Presenter : MonoBehaviour {

	[SerializeField] private Button upButton;
	[SerializeField] private Button downButton;
	[SerializeField] private Button resetButton;
	[SerializeField] private Text scoreText;

	public ReactiveProperty<int> Score = new ReactiveProperty<int>();
	// Use this for initialization
	void Start () 
	{
		this.upButton.OnClickAsObservable().Subscribe
		(
			_ => this.Score.Value++
		);
		this.downButton.OnClickAsObservable().Subscribe
		(
			_ => this.Score.Value--
		);
		this.resetButton.OnClickAsObservable().Subscribe
		(
			_ => this.Score.Value = 0
		);

		this.Score.SubscribeToText(this.scoreText);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
