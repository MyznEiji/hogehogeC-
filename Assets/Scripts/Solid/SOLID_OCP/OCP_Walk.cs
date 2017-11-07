using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OCP_Walk : IPlayerState1 {
    private readonly Vector3 _velocity;
    private readonly Transform _transform;

    public OCP_Walk(Vector3 velocity,Transform transform)
    {
        _velocity = velocity;
        _transform = transform;
    }
    public void Move()
    {
        _transform.position += _velocity;
    }
}
