using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITweenCube : MonoBehaviour 
{
    public GameObject obj;
    Vector3 scale,pos;
    Quaternion rot;
    void Start()
    {
        scale = obj.transform.localScale;
        pos = obj.transform.position;
        rot = obj.transform.rotation;
        print("x = MoveRight,s = Scale,r = Rotate");
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.X))
        {
            MoveRight();
        }
        if(Input.GetKey(KeyCode.S))
        {
            Scale();
        }
        if(Input.GetKey(KeyCode.R))
        {
            Rotate();
        }
    }
    public void MoveRight()
    {
        iTween.MoveTo
        (
            obj,
            iTween.Hash
            (
                "x",pos.x + 2,
                "time",1.5
            )
        );
        pos = obj.transform.localPosition;
    }
    public void Scale()
    {
        iTween.ScaleTo
        (
            obj,
            iTween.Hash
            (
                "x",scale.x + 1,
                "y",scale.y + 1,
                "z",scale.z + 1,
                "time",1.5
            )
        );
        scale = obj.transform.localScale;
    }
    public void Rotate()
    {
        iTween.RotateTo
        (
            obj,
            iTween.Hash
            (
                "x",rot.x + 90,
                "time",1.5
            )
        );
        rot = obj.transform.rotation;
    }
}
