using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class DoubleClickButton : MonoBehaviour
{
    [SerializeField] private Button button;

    void Start () 
    {
		    button.onClick.AsObservable ()
            .Buffer (2)
            .Subscribe (_ => Debug.Log ("Clicked!"));
    }
}