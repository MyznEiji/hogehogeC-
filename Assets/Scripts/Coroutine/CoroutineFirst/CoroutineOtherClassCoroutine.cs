using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoroutineOtherClassCoroutine : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine("Sample");	
	}
	private IEnumerator Sample()
	{
		//Test2.Sample()を実行して、それが終わるまで待つ
		Test test2 = new Test();
		yield return StartCoroutine(test2.Sample(5,0.5f));

		Debug.LogFormat("{0}","End");
		Debug.LogWarning("Test Warning");
		Debug.LogError("Test Error");
	}
}

public class Test
{
	public IEnumerator Sample(int num,float interval)
	{	
		for(int i = 0; i < num; i++)
		{
			Debug.Log("Test Sample:" + i);
			yield return new WaitForSeconds(interval);
		}
	}
}
