using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bossbullet : MonoBehaviour
{
    public GameObject P1;
    public GameObject bossB;
    public float Bulletspeed = 5.0f;
    public float deleteTime = 2.5f;
    Vector2 old;
    Vector2 cur;


    // Start is called before the first frame update
    void Start()
    {
        P1 = GameObject.Find("peng1");
        old = P1.transform.position;
        Destroy(gameObject, deleteTime);
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
            bossB.SetActive(false);
            //接触したゲームオブジェクトの子要素にする
            transform.SetParent(collision.transform);
            //当たり判定を無効化
            GetComponent<CircleCollider2D>().enabled = false;
            //物理エンジンを無効化
            GetComponent<Rigidbody2D>().simulated = false;
            Destroy(gameObject);

            GameObject director = GameObject.Find("GameObject"); //directorにGameDirectorを入れる
            director.GetComponent<GameDire>().DecreaseHP1();　//コンポーネントのスクリプトを使用
            director.GetComponent<sound>().Se1();
        }

        if (collision.CompareTag("wall"))
        {
            bossB.SetActive(false);
            //接触したゲームオブジェクトの子要素にする
            transform.SetParent(collision.transform);
            //当たり判定を無効化
            GetComponent<CircleCollider2D>().enabled = false;
            //物理エンジンを無効化
            GetComponent<Rigidbody2D>().simulated = false;
            Destroy(gameObject);

        }


    }
}