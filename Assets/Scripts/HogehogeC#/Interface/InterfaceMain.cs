﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ICalcInterface calc;
		InterfaceAdd iadd = new InterfaceAdd();
		InterfaceSub isub = new InterfaceSub();

		calc = iadd;
		print(calc.Calc(3,1));

		calc = isub;
		print(calc.Calc(3,1));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
