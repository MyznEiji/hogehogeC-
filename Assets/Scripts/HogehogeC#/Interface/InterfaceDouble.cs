using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceDouble : MonoBehaviour,IFirst,ISecond {

	public void Show(int x){
		print(x);
	}

	public void Show(int x,int y){
		print("x = " + x + ", y =  " + y);
	}

	void IFirst.Show(int x){
		print("IFirstが実行されました" + x);
	}

	void ISecond.Show(int x){
		print("ISecondが実行されました" + x);
	}
}
