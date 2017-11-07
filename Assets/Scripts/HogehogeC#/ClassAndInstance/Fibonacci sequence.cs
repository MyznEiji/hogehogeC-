using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonaccisequence : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public long CalcFibo(int n){
	long fb;
	if(n == 1 || n ==2){
		fb =1;
	}else{
		fb = CalcFibo(n-1) + CalcFibo(n-2);
	}
	return fb;
	}


	// nが5で呼び出されたとすると、
	// fb = CalcFibo(4) + CalcFibo(3);
	// つまり4項目と3項目の和になります。ここで、
	// CalcFibo(4) = CalcFibo(3) + CalcFibo(2);
	// CaclFibo(3) = CalcFibo(2) + CalcFino(1);
	// となります。
	// CalcFibo(1) = CalcFibo(2) = 1 
	// より、
	// CalcFibo(3) = 1 + 1 = 2
	// CalcFibo(4) = 2 + 1 = 3
	// となり、
	// CalcFibo(5) = 3 + 2 = 5;
	// となります。
}
