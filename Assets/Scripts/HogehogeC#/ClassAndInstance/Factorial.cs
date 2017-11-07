using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factorial : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//階乗の計算
	public long CalcFact(int n){
		long fact;

		if(n == 0)
		{
			fact = 1;
		}else
		{
			fact = n * CalcFact(n-1);
		}
		return fact;
	}


	// nが6で呼び出されたとします。すると、
	// fact = 6 * CalcFact(5);
	// と処理されます。次にCalcFact(5)が処理され、
	// fact = 6 * 5 * CalcFact(4);
	// となります。これを繰り返し、
	// 6! 
	// = 6 * CalcFact(5);
	// = 6 * 5 * CalcFact(4);
	// = 6 * 5 * 4 * CalcFact(3);
	// = 6 * 5 * 4 * 3 * CalcFact(2);
	// = 6 * 5 * 4 * 3 * 2 * CalcFact(1);
	// = 6 * 5 * 4 * 3 * 2 * 1;
	// = 720; 
	// となります。	
}

