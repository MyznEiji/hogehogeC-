using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OCP_Run : IPlayerState1 {
    private readonly Vector3 _velocity;
    private readonly Transform _transform;

    public OCP_Run(Vector3 velocity, Transform transform)
    {
        _velocity = velocity;
        transform = transform;

    }

    public void Move()
    {
        _transform.position += _velocity * 3;
    }
}
