using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    List<IEnemy> enemies;
    public EnemyManager(List<IEnemy> enemies)
    {
        this.enemies = enemies;
    }
    public void Move()
    {
        foreach(var enemy in enemies)
        {
            enemy.Move();
        }
    }
}
