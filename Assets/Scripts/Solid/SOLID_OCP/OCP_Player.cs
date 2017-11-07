using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OCP_Player : MonoBehaviour {

    [SerializeField] private Vector3 velocity;
    private IPlayerState1 state;

    public void Awake()
    {
        state = new OCP_Run(velocity,transform);
    }

    void Update()
    {
        state.Move();
    }
}
