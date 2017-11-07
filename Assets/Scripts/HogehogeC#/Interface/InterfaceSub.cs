using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceSub : ICalcInterface {
	public int Calc(int a, int b){
		return a-b;
	}
}