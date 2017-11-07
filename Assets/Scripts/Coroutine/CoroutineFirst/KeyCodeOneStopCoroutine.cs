using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCodeOneStopCoroutine : MonoBehaviour {
	private IEnumerator coroutine;
	// Use this for initialization
	void Start () {
		coroutine = Sample(10,0.5f);
		StartCoroutine(coroutine);
	}
	
	// Update is called once per frame
	void Update()
	{
		if(Input.GetKey(KeyCode.Alpha1)) StopCoroutine(coroutine);
	}
	private IEnumerator Sample(int num, float interval)
	{
		for(int i = 0; i < num; i++)
		{
			Debug.Log("i : " + i);
			yield return new WaitForSeconds(interval);
		}
	}
}
