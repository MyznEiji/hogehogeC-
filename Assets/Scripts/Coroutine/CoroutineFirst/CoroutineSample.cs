using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSample : MonoBehaviour 
{
	bool isRunning = false;
	Coroutine coroutine;
	[SerializeField] Renderer leftRenderer,rightRenderer = null;
	Stack<Coroutine> coroutineStack = new Stack<Coroutine>();

	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			var coroutine = StartCoroutine(ChangeColorCoroutine());
			coroutineStack.Push(coroutine);
		}
		if(Input.GetMouseButtonDown(1)) StartCoroutine(ChangeColorCoroutine(1));

		if(Input.GetMouseButtonUp(0))
		{
			foreach(var coroutine in coroutineStack)
			{
				StopCoroutine(coroutine);
			}
			ChangeColor(GetComponent<Renderer>(),Color.white);
			ChangeColor(leftRenderer,Color.green);
			ChangeColor(rightRenderer,Color.green);
			isRunning = false;
		}
	}
	IEnumerator ChangeColorCoroutine()
	{
		float sum = 0;

		if(isRunning){yield break;}
		isRunning = true;

		var renderer = GetComponent<Renderer>();
		ChangeColor(renderer,Color.blue);

		var leftCoroutine = StartCoroutine(ChangeColorCoroutineWithRuntime(leftRenderer,(result) => sum += result));
		var rightCoroutine = StartCoroutine(ChangeColorCoroutineWithRuntime(rightRenderer,(result) => sum += result));

		coroutineStack.Push(leftCoroutine);
		coroutineStack.Push(rightCoroutine);

		yield return leftCoroutine;
		yield return rightCoroutine;

		yield return new WaitForSeconds(0.2f);
		ChangeColor(renderer,Color.white);
		isRunning = false;

		//待機時間の合計をログに出力
		print(sum);
	}

	IEnumerator ChangeColorCoroutineWithRuntime(Renderer renderer,UnityEngine.Events.UnityAction<float> callback)
	{
		ChangeColor(renderer,Color.red);

		float waitSec = Random.Range(0.2f,1f);
		yield return new WaitForSeconds(waitSec);

		ChangeColor(renderer,Color.green);
		//待機した時間を返す
		callback(waitSec);
	}
	//マテリアルの色を変える
	void ChangeColor(Renderer renderer,Color color)
	{
		renderer.material.color = color;
	}

	IEnumerator ChangeColorCoroutine(float time)
	{
		MaterialPropertyBlock materialBlock = new MaterialPropertyBlock();
		Renderer renderer = GetComponent<Renderer>();
		Color firstColor = Color.green;
		Color endColor = Color.red;

		float endTime = Time.time + time;
		
		while( true ){
			float diff = endTime - Time.time;
			if( diff <= 0 ) { break; }
			float rate = 1 - Mathf.Clamp01( diff / time);
			materialBlock.SetColor("_Color", Color.Lerp(firstColor, endColor, rate));
			renderer.SetPropertyBlock( materialBlock );
			leftRenderer.SetPropertyBlock(materialBlock);
			rightRenderer.SetPropertyBlock(materialBlock);
			yield return null;
		}
		materialBlock.SetColor("_Color", Color.red);
		renderer.SetPropertyBlock( materialBlock );

	}
}
