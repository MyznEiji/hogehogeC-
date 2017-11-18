using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonController : MonoBehaviour 
{

    public void RightPageChange()
    {
        GetComponent<RectTransform>().DOAnchorPos(new Vector2(-200,0),1);
    }
    public void CenterPageChange()
    {
        GetComponent<RectTransform>().DOAnchorPos(new Vector2(0,0),1);
    }
    public void LeftPageChange()
    {
        GetComponent<RectTransform>().DOAnchorPos(new Vector2(200,0),1);
    }
    //void Start()
    //{
	
    //}

    //void Update()
    //{
	
    //}
}
