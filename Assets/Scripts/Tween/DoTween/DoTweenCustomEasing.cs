using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenCustomEasing : MonoBehaviour 
{

    [SerializeField]private AnimationCurve cosutomEasing;
    void Start()
    {
        transform.DOLocalMoveX(2f,3f).SetEase(cosutomEasing);
    }

    //void Update()
    //{
	
    //}
}
