using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy12 : IEnemy {
    private int hp;
    private int speed;
    private Vector3 position = new Vector3(0,0,0);

    public Enemy12(int hp,int speed)
    {
        this.hp = hp;
        this.speed = speed;
    }

    public void Move()
    {
        position += Vector3.forward * Time.deltaTime * speed;
        Debug.Log("Enemy2 Position" + position);
    }
    //void Start()
    //{
	
    //}

    //void Update()
    //{
	
    //}
}
