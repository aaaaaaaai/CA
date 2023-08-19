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
            //������������W�ƍs���������W����͂���Ɗp�x��Ԃ�
            float angle;
            if (axisH != 0 || axisV != 0)
            {
                //�ړ����ł���Ίp�x�v�Z
                float dx = p2.x - p1.x;
                float dy = p2.y - p1.y;
                //�A�[�N�^���W�F���g�Ń��W�A�������߂�
                float rad = Mathf.Atan2(dy, dx);
                //���W�A����x�ɕϊ�����
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

