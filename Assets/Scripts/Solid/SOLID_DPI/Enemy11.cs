using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy11 : IEnemy {
    private Transform target;
    private Vector3 position = new Vector3(0,0,0);

    public Enemy11(Transform target)
    {
        this.target = target;
    }

    public void Move()
    {
        position = Vector3.Lerp(position,target.position,Time.deltaTime);
        Debug.Log("Enemy1 Position" + position);
    }
}
