using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    private int point = 0;                      //���_�̕ϐ�

    public const int LargeStar_Point = 10;      //LargeStar�̓��_
    public const int SmallStar_Point = 20;      //SmallStar�̓��_
    public const int SmallCloud_Point = 30;     //SmallCloud�̓��_
    public const int LargeCloud_Point = 40;     //LargeCloud�̓��_



    public Text pointstext;


    private void Start()
    {

        pointstext.text = "���_:" + point.ToString();
    }



    void OnCollisionEnter(Collision collision)
    {


        // LargeStarTag���t�����I�u�W�F�N�g�ɐڐG�����ꍇ
        if (collision.gameObject.tag == "LargeStarTag")
        {

            point += LargeStar_Point;

            pointstext.text = "���_:" + point.ToString();
        }
        // SmallStarTag���t�����I�u�W�F�N�g�ɐڐG�����ꍇ
        else if (collision.gameObject.tag == " SmallStarTag")
        {

            point += SmallStar_Point;

            pointstext.text = "���_:" + point.ToString();
        }
        // LargeCloudTag���t�����I�u�W�F�N�g�ɐڐG�����ꍇ
        else if (collision.gameObject.tag == "LargeCloudTag")
        {

            point += LargeCloud_Point;

            pointstext.text = "���_:" + point.ToString();
        }
        // SmallCloudTag���t�����I�u�W�F�N�g�ɐڐG�����ꍇ
        else if (collision.gameObject.tag == "SmallCloudTag")
        {

            point += SmallCloud_Point;

            pointstext.text = "���_:" + point.ToString();
        }



    }
}
