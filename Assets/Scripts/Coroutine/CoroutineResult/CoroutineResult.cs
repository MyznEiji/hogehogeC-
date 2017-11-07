	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using System;

	public class CoroutineResult : MonoBehaviour {
		// // どちらのメソッドからも見える変数に値を代入する
		// int result;
		// // Use this for initialization
		// void Start () {
		// 	StartCoroutine(Hoge());	
		// }

		// IEnumerator Hoge()
		// {
		// 	yield return StartCoroutine(Fuga());
		// 	print(result);
		// }

		// IEnumerator Fuga()
		// {
		// 	yield return new WaitForSeconds(2f);
		// 	result = 355;
		// }





		// //コールバック関数を渡して結果を返してもらう
		// void Start()
		// {
		// 	StartCoroutine(Hoge());
		// }
		// IEnumerator Hoge()
		// {
		// 	int? result = null;
		// 	 yield return StartCoroutine(Fuga(r => result =r));
			
		// 	//下を実行するとresultはnullなのでerrorが投げられる。
		// 	//yield return new WaitForSeconds(3.0f);
		// 	print(result.Value);
		// }

		// IEnumerator Fuga(Action<int> callback)
		// {
		// 	yield return new WaitForSeconds(2.0f);
		// 	callback(335);
		// }





		// IEnumerator#Current を使用する
		void Start()
		{
			StartCoroutine(Hoge());
		}
		IEnumerator Hoge()
		{
			var coroutine = Fuga();
			yield return StartCoroutine(coroutine);
			var result = (int)coroutine.Current;
			print(result);
		}

		IEnumerator Fuga()
		{
			yield return new WaitForSeconds(2.0f);
			yield return 335;
		}
	}
