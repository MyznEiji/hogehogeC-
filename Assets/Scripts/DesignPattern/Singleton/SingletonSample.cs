using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonSample
{
	private static SingletonSample instance = new SingletonSample();
	private SingletonSample()
	{
		Debug.Log("Create SingletonSample instance.");
	}

	public static SingletonSample GetInstance
	{
		get
		{
			if(instance == null)
			{
				instance = new SingletonSample();
			}
			return instance;
		}
	}

	public int testNum = 10;
	public void setNum(int num)
	{
		testNum = num;
	}
}
