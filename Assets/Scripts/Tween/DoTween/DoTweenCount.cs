using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoTweenCount : MonoBehaviour 
{
    public Text text;
    private int num;
    public int Num
    {
        get
        {
            return num;
        }
        set
        {   
            num = value;
            text.text = num.ToString();
        }
    }
    void Start()
    {
        DOTween.To(() => Num,(n) => Num = n,100,3f).SetEase(Ease.Linear);
    }

    //void Update()
    //{
	
    //}
    
}
