using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossController : MonoBehaviour
{ 
    public GameObject BOSS;
    public int count = 0;

    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            GameObject director = GameObject.Find("GameObject"); //director��GameDirector������
            director.GetComponent<GameDire>().bossDecreaseHP();
            count++;
            if (count == 100)
            {

                BOSS.SetActive(false);
                //�ڐG�����Q�[���I�u�W�F�N�g�̎q�v�f�ɂ���
                transform.SetParent(collision.transform);
                //�����蔻��𖳌���
                GetComponent<BoxCollider2D>().enabled = false;
                //�����G���W���𖳌���
                GetComponent<Rigidbody2D>().simulated = false;
                Destroy(gameObject);

                Defeat();
            }

        }

        if (collision.CompareTag("Player"))
        {

            GameObject director = GameObject.Find("GameObject"); //director��GameDirector������
            director.GetComponent<GameDire>().DecreaseHP1();�@//�R���|�[�l���g�̃X�N���v�g���g�p
            director.GetComponent<sound>().Se1();
        }
    }

    public void Defeat() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CLEAR");
    }
}