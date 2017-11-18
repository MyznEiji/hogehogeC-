using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenUnityChan : MonoBehaviour 
{

    void Start()
    {
        transform.DOLocalPath(new Vector3[]{new Vector3(2.6f,0,-2f),Vector3.zero},4f,PathType.CatmullRom)
        .SetLookAt(0.3f,Vector3.forward)
        .SetEase(Ease.Linear);
        
    }

    //void Update()
    //{
	
    //}
}
