using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateWalk : IState {
    private readonly float speed;
    public StateWalk(float speed)
    {
        this.speed  = speed;
    }
    public void Move()
    {
        Debug.Log("speedB = " + speed + "で歩いています");
    }
}
