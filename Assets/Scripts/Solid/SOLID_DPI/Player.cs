using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private List<IEnemy> enemies;
    private EnemyManager enemyManager;

    void Start()
    {
        Instantiate();
        enemyManager = new EnemyManager(enemies);
    }
    void Update()
    {
        enemyManager.Move();
    }
    void Instantiate()
    {
        enemies = new List<IEnemy>();
        enemies.Add(new Enemy11(transform));
        enemies.Add(new Enemy12(20,50));
    }
}
