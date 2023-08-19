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
            GameObject director = GameObject.Find("GameObject"); //directorにGameDirectorを入れる
            director.GetComponent<GameDire>().bossDecreaseHP();
            count++;
            if (count == 100)
            {

                BOSS.SetActive(false);
                //接触したゲームオブジェクトの子要素にする
                transform.SetParent(collision.transform);
                //当たり判定を無効化
                GetComponent<BoxCollider2D>().enabled = false;
                //物理エンジンを無効化
                GetComponent<Rigidbody2D>().simulated = false;
                Destroy(gameObject);

                Defeat();
            }

        }

        if (collision.CompareTag("Player"))
        {

            GameObject director = GameObject.Find("GameObject"); //directorにGameDirectorを入れる
            director.GetComponent<GameDire>().DecreaseHP1();　//コンポーネントのスクリプトを使用
            director.GetComponent<sound>().Se1();
        }
    }

    public void Defeat() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CLEAR");
    }
}