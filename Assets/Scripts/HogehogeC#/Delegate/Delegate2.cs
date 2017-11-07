using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

delegate void ShowMessage();
public class Delegate2 : MonoBehaviour {

    void Start()
    {
        Person p1 = new Person("みやぞん");
        Person p2 = new Person("あらぽん");

        ShowMessage show = new ShowMessage(p1.ShowMessage);
        show += new ShowMessage(p2.ShowMessage);
        show += new ShowMessage(A);
        show += new ShowMessage(B);

        show();
    }

    static void A(){Debug.Log("Aが呼ばれました。");}
    static void B(){Debug.Log("Bが呼ばれました。");}
    static void C(){Debug.Log("Cが呼ばれました。");}

    //void Update()
    //{
	
    //}
}

class Person
{
    string name;
    public Person(string name)
    {
        this.name = name;
    }
    public void ShowMessage()
    {
        Debug.LogFormat("名前 : {0}",this.name);
    }
}
