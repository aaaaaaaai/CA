using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    public GameObject P1;
    public GameObject enemyB;
    public float Bulletspeed = 5.0f;
    Vector2 old;
    Vector2 cur;


    // Start is called before the first frame update
    void Start()
    {
        P1 = GameObject.Find("peng1");
        old = P1.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, old, Bulletspeed * Time.deltaTime);
        cur = transform.position;


        if (cur == old)
        {
            delete();
        }
    }
    public void delete()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
                enemyB.SetActive(false);
                //�ڐG�����Q�[���I�u�W�F�N�g�̎q�v�f�ɂ���
                transform.SetParent(collision.transform);
                //�����蔻��𖳌���
                GetComponent<CircleCollider2D>().enabled = false;
                //�����G���W���𖳌���
                GetComponent<Rigidbody2D>().simulated = false;
                Destroy(gameObject);

            GameObject director = GameObject.Find("GameObject"); //director��GameDirector������
            director.GetComponent<GameDire>().DecreaseHP();
            director.GetComponent<sound>().Se1();
            //�R���|�[�l���g�̃X�N���v�g���g�p
        }


    }
}