using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlashingUI : MonoBehaviour 
{
    CanvasGroup canvasGroup;
    [SerializeField] Ease easeType;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.DOFade(0.0f,3f).SetEase(easeType).SetLoops(-1,LoopType.Yoyo);
    }

    //void Update()
    //{
	
    //}
}
