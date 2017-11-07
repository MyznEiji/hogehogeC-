using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineInCoroutine : MonoBehaviour {

void Start () {  
    StartCoroutine ("Sample1");  
}  
  
private IEnumerator Sample1() {  
    for (int i = 0; i < 5; i++) {  
        Debug.Log ("Sample1 i:" + i);  
  
        // 別のコルーチンを実行して終わるまで待つ  
        yield return StartCoroutine ("Sample2");  
    }  
}  
  
private IEnumerator Sample2() {  
    for (int i = 0; i < 3; i++) {  
        Debug.Log ("Sample2 i:" + i);  
        yield return new WaitForSeconds (1f);  
    }  
}  
}
