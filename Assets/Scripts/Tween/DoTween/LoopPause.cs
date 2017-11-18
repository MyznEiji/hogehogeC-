using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LoopPause : MonoBehaviour 
{
    public Tween tween;
    void Start()
    {
        LoopPauseCube();
        print("左クリックでストップ、右クリックで再開");
    }

    void Update()
    {
        if(Input.GetMouseButton(0))tween.Pause();
        if(Input.GetMouseButton(1))tween.Restart();
    }

    void LoopPauseCube()
    {
        tween =transform.DOLocalMoveX(1f,2f)
        .SetEase(Ease.Linear)
        .SetLoops(-1,LoopType.Yoyo);
        
    }
}
