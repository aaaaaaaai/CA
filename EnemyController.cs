using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1.0f;

    public GameObject P1;
    public GameObject bird;
    public int count = 0;
    public static int killcount = 0;
   
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        P1 = GameObject.Find("peng1");
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.y > -2.0f)
        //{
            Vector2 old = transform.position;
            transform.position = Vector2.MoveTowards(transform.position, P1.transform.position, speed * Time.deltaTime);
            Vector2 cur = transform.position;
        //}

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            count++;
            if (count == 1)
            {
                killcount++;
                bird.SetActive(false);
                //接触したゲームオブジェクトの子要素にする
                transform.SetParent(collision.transform);
                //当たり判定を無効化
                GetComponent<BoxCollider2D>().enabled = false;
                //物理エンジンを無効化
                GetComponent<Rigidbody2D>().simulated = false;
                Destroy(gameObject);
            }

        }

        if (collision.CompareTag("Player")){
            bird.SetActive(false);
            //接触したゲームオブジェクトの子要素にする
            transform.SetParent(collision.transform);
            //当たり判定を無効化
            GetComponent<BoxCollider2D>().enabled = false;
            //物理エンジンを無効化
            GetComponent<Rigidbody2D>().simulated = false;
            Destroy(gameObject);

            GameObject director = GameObject.Find("GameObject"); //directorにGameDirectorを入れる
            director.GetComponent<GameDire>().DecreaseHP();　//コンポーネントのスクリプトを使用
            director.GetComponent<sound>().Se1();
        }
    }


}