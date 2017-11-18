using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenBasic : MonoBehaviour
{

    void Start()
    {
        // HogehogeDoTween();//テストとして移動と向きと大きさを変化させる
        // HogehogeDoTween2();//滑らかな移動
        // HogehogeDOTween3();//パンチング運動(平行移動)アニメーション
        // HogehogeDoTween4();//パンチング運動(拡大縮小)アニメーション
        // HogehogeDoTween5();//シェイクアニメーション
        // HogehogeDoTween6();//ジャンプアニメーション
        // HogehogeDoTween7();
    }

    //void Update()
    //{

    //}

    //基本的な移動と向きと大きさの変化のアニメーション
    public void HogehogeDoTween()
    {
        transform.DOLocalMove
        (
            new Vector3(3f, 2, 0),
            2f
        ).SetEase
        (
            Ease.InOutQuart
        );

        transform.DOLocalRotate
        (
            new Vector3(120f, 0, 0),
            2f
        );

        transform.DOScale
        (
            new Vector3(3f, 4f, 5f),
            2f
        );
    }
    //滑らかなアニメーション
    public void HogehogeDoTween2()
    {
        transform.DOLocalPath
        (
            new Vector3[]
            {
                new Vector3(3f,3f),
                Vector3.zero,
                new Vector3(-3f,2f)
            },
            2f,
            PathType.CatmullRom
        );
    }
    //パンチング運動(振動)アニメーション
    public void HogehogeDOTween3()
    {
        transform.DOPunchPosition(new Vector3(5f, 0f), 2f, 100, 100f);
        
    }
    //パンチング運動(拡大縮小)アニメーション
    public void HogehogeDoTween4()
    {
        transform.DOPunchScale(new Vector3(3f, 3f, 3f), 3f, 3, 0);
    }
    //シェイクアニメーション
    public void HogehogeDoTween5()
    {
        transform.DOShakePosition(2f);
    }
    //ジャンプのアニメーション
    public void HogehogeDoTween6()
    {
        transform.DOJump(new Vector3(-3f, 0, 0), 3, 3, 3f).SetEase(Ease.Linear);
    }
    //Moveメソッドの種類
    public void HogehogeDoTween7()
    {
        // transform.DOLocalMoveX(3f,1.5f); //X軸方向に移動する
        transform.DOLocalMoveX(3f, 1.5f).From(); //X軸方向に現在の位置に向かうメソッド
    }

}
