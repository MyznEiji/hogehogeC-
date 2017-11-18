using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpriteController : MonoBehaviour 
{
    void Start()
    {
        transform.DOMove(new Vector3(2f,0,0),1f).SetLoops(-1,LoopType.Incremental);
    }

    //void Update()
    //{
	
    //}
}
