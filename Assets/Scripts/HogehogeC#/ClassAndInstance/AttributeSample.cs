#define TEST_ATTRIBUTE
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttributeSample : MonoBehaviour {

	// Use this for initialization

	void Start () {
		TestAttribute();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //[Conditional("TEST_ATTRIBUTE")]
	static void TestAttribute(){
		print("colled TestAttribute method");
	}
}
