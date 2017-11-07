using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolCube : MonoBehaviour {
    private float activeTime = 0;

    //void Start()
    //{
	
    //}

    void Update()
    {
        if(gameObject.activeInHierarchy)
        {
            activeTime += Time.deltaTime;
        }
        if(activeTime > 1.0f)
        {
            gameObject.SetActive(false);
            activeTime = 0; 
        }
    }
}
