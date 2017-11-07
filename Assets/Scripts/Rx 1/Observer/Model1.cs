using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model1 : MonoBehaviour {

    void Start () 
    {
        Subject subject = new Subject ();

        Observer1 observer1 = new Observer1 ();
		Observer2 observer2 = new Observer2();

        subject.RegisterObserver (observer1);
        subject.SetData ("Hello World!");

		subject.RegisterObserver (observer2);
		subject.SetData("Re:Hello World!");

		subject.RemoveObserver(observer1);
		subject.SetData("Re:Re:Hello World!");
    }
}
