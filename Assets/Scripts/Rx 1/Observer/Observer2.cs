using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer2 : IObserver {
	public void Notify(string message)
	{
		Debug.Log("Observer2" + message);
	}
}
