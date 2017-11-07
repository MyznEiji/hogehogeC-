using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Mystruct.show();
		Mystruct.x = 20;
		Mystruct.show();
	}

}

struct Mystruct{
	public static int x = 10;
	
	public static void show()
	{
		Debug.Log(x);
	}
}
