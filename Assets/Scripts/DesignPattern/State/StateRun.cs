using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateRun : IState {
    private readonly float speed;
    public StateRun(float speed)
    {
        this.speed =speed;
    }
    public void Move()
    {
        Debug.Log("speedA = " + speed + "で走っています");
    }
    //void Start()
    //{
	
    //}

    //void Update()
    //{
	
    //}
}
