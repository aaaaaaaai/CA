using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody2D rbody;

    public float angleZ = -90.0f;
    float axisH;
    float axisV;
    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKey("left shift"))
        {
            speed = 10.0f;
        }
        else {
            speed = 5.0f;
        }
        float InputX = Input.GetAxisRaw("Horizontal");
        float InputY = Input.GetAxisRaw("Vertical");
        rbody.velocity = new Vector2(InputX, InputY) * speed;

        Vector2 from = transform.position;
        Vector2 to = new Vector2(from.x + axisH, from.y + axisV);
        angleZ = GetAngle(from, to);


        float GetAngle(Vector2 p1, Vector2 p2)
        {
            //自分がいる座標と行きたい座標を入力すると角度を返す
            float angle;
            if (axisH != 0 || axisV != 0)
            {
                //移動中であれば角度計算
                float dx = p2.x - p1.x;
                float dy = p2.y - p1.y;
                //アークタンジェントでラジアンを求める
                float rad = Mathf.Atan2(dy, dx);
                //ラジアンを度に変換する
                angle = rad * Mathf.Rad2Deg;
            }
            else
            {
                angle = angleZ;
            }


            return angle;
        }
    }
}

