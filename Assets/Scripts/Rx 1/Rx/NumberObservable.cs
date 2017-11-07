using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;


public class NumberObservable : IObservable<int>
{
	private Subject<int> source = new Subject<int>();

	public void Execute(int value)
	{
		if(value == 0)
		{
			this.source.OnError(new Exception("value is 0"));
			this.source = new Subject<int>();
			return;
		}
		this.source.OnNext(value);
	}
	public void Completed()
	{
		this.source.OnCompleted();
	}
	public IDisposable Subscribe(IObserver<int> observer)
	{
		return this.source.Subscribe(observer);
	}

}

// public class NumberObservable : IObservable<int> {

// 	private List<IObserver<int>> observers = new List<IObserver<int>>();
	
// 	public void Execute(int value)
// 	{
// 		if (value == 0)
// 		{
// 			foreach(var obs in observers)
// 			{
// 				obs.OnError(new Exception("value is 0"));
// 			}

// 			this.observers.Clear();
// 			return;
// 		}

// 		foreach(var obs in observers)
// 		{
// 			obs.OnNext(value);
// 		}
// 	}

// 	public void Completed()
// 	{
// 		foreach(var obs in observers)
// 		{
// 			obs.OnCompleted();
// 		}

// 		this.observers.Clear();
// 	}

// 	public IDisposable Subscribe(IObserver<int> observer)
// 	{
// 		this.observers.Add(observer);
// 		return new RemoveListDisposable(observers,observer);
// 	}

// 	private class RemoveListDisposable : IDisposable
// 	{
// 		private List<IObserver<int>> observers = new List<IObserver<int>>();
// 		private IObserver<int> observer;

// 		public RemoveListDisposable(List<IObserver<int>> observers,IObserver<int> observer)
// 		{
// 			this.observers = observers;
// 			this.observer = observer;
// 		}

// 		public void Dispose()
// 		{
// 			if(this.observers == null)
// 			{
// 				return;
// 			}

// 			if(observers.IndexOf(observer) != -1)
// 			{
// 				this.observers.Remove(observer);
// 			}
// 			this.observers = null;
// 			this.observer = null;
// 		}
//  	}
// }
