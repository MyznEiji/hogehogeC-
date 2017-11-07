using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonSampleObject : MonoBehaviour {
	private static SingletonSampleObject mInterface;
	private SingletonSampleObject()
	{
		Debug.Log("Create SampleSingleton GameObject instance.");
	}
	public static SingletonSampleObject GetInstance
	{
		get
		{
			if(mInterface == null)
			{
				GameObject go = new GameObject("SingletonSample");
				mInterface = go.AddComponent<SingletonSampleObject>();
			}
			return mInterface;
		}
	}
}
