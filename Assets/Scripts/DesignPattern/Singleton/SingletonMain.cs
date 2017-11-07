using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMain : MonoBehaviour {
	private SingletonSample sample1;
	private SingletonSample sample2;
	private SingletonSampleObject sample3;
	private SingletonSampleObject sample4;

	// Use this for initialization
	void Start () {
		sample1 = SingletonSample.GetInstance;
		sample2 = SingletonSample.GetInstance;

		if(sample1 == sample2) Debug.Log("sampel1 == samaple2");
		Debug.Log(sample2.testNum);
		sample1.setNum(100);
		Debug.Log(sample2.testNum);

		sample3 = SingletonSampleObject.GetInstance;
		sample4 = SingletonSampleObject.GetInstance;

		if(sample3 == sample4)
		{
			Debug.Log("sample3 == sample4");
		}
	}
}
