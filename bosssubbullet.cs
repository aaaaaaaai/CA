using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosssubbullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject bosssubullet;
    public float Bulletspeed = -5.0f;
    public float deleteTime = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, deleteTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, Bulletspeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bosssubullet.SetActive(false);
            //�ڐG�����Q�[���I�u�W�F�N�g�̎q�v�f�ɂ���
            transform.SetParent(collision.transform);
            //�����蔻��𖳌���
            GetComponent<CircleCollider2D>().enabled = false;
            //�����G���W���𖳌���
            GetComponent<Rigidbody2D>().simulated = false;
            Destroy(gameObject);

            GameObject director = GameObject.Find("GameObject"); //director��GameDirector������
            director.GetComponent<GameDire>().DecreaseHP();�@//�R���|�[�l���g�̃X�N���v�g���g�p
            director.GetComponent<sound>().Se1();
        }

        if (collision.CompareTag("wall"))
        {
            bosssubullet.SetActive(false);
            //�ڐG�����Q�[���I�u�W�F�N�g�̎q�v�f�ɂ���
            transform.SetParent(collision.transform);
            //�����蔻��𖳌���
            GetComponent<CircleCollider2D>().enabled = false;
            //�����G���W���𖳌���
            GetComponent<Rigidbody2D>().simulated = false;
            Destroy(gameObject);

        }


    }
}
