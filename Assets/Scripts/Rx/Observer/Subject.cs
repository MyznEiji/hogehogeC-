using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : ISubject 
{
    private List<IObserver> observers;
    private string message;

    public Subject ()
    {
        observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add (observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove (observer);
    }

    public void NotifyObserver()
    {
        foreach (IObserver observer in observers) 
        {
            observer.Notify (message);
        }
    }

    public void SetData(string message)
    {
        this.message = message;

        NotifyObserver ();
    }
}