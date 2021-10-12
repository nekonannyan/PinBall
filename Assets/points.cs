using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    private int point = 0;                      //得点の変数

    public const int LargeStar_Point = 10;      //LargeStarの得点
    public const int SmallStar_Point = 20;      //SmallStarの得点
    public const int SmallCloud_Point = 30;     //SmallCloudの得点
    public const int LargeCloud_Point = 40;     //LargeCloudの得点



    public Text pointstext;


    private void Start()
    {

        pointstext.text = "得点:" + point.ToString();
    }



    void OnCollisionEnter(Collision collision)
    {


        // LargeStarTagが付いたオブジェクトに接触した場合
        if (collision.gameObject.tag == "LargeStarTag")
        {

            point += LargeStar_Point;

            pointstext.text = "得点:" + point.ToString();
        }
        // SmallStarTagが付いたオブジェクトに接触した場合
        else if (collision.gameObject.tag == " SmallStarTag")
        {

            point += SmallStar_Point;

            pointstext.text = "得点:" + point.ToString();
        }
        // SmallCloudTagが付いたオブジェクトに接触した場合
        else if (collision.gameObject.tag == "LargeCloudTag")
        {

            point += SmallCloud_Point;

            pointstext.text = "得点:" + point.ToString();
        }
        // LargeCloudTagが付いたオブジェクトに接触した場合
        else if (collision.gameObject.tag == "SmallCloudTag")
        {

            point += LargeCloud_Point;

            pointstext.text = "得点:" + point.ToString();
        }



    }
}
