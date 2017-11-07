using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightTestUnused : MonoBehaviour 
{
	void Start()
	{
        var instance_i = new Letter("i");
        instance_i.ShowLetter();
        var instance_a = new Letter("a");
        instance_a.ShowLetter();
        var instance_m = new Letter("m");
        instance_m.ShowLetter();
        instance_a.ShowLetter();
        instance_m.ShowLetter();
        instance_a.ShowLetter();
        var instance_n = new Letter("n");
        instance_n.ShowLetter();
	}
}
