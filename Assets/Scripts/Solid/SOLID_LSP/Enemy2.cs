using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour, IMovable {
    public void MoveTo(Vector3 pos)
    {
        transform.position += pos;
    }
    //void Start()
    //{
	
    //}

    //void Update()
    //{
	
    //}
}
