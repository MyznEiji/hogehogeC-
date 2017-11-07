using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer1 : IObserver {
	public void Notify(string message)
	{
		Debug.Log("Observer1" + message);
	}
}
